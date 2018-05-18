﻿using Azylee.Core.DataUtils.CollectionUtils;
using Azylee.Core.DataUtils.StringUtils;
using Azylee.Core.DataUtils.UnitConvertUtils;
using Oreo.BigBirdDeployer.Commons;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oreo.BigBirdDeployer.Views
{
    public partial class ProjectConsoleForm : Form
    {
        private int ConsoleLine = 0;
        private int ConsoleLength = 0;
        private int MaxLength = 500 * 1024;
        private bool IsWrite = false;
        private string Caption = "";
        private int WriteInterval = 1000;
        private ConcurrentQueue<string> Lines = new ConcurrentQueue<string>();
        public ProjectConsoleForm()
        {
            InitializeComponent();
        }
        private void ProjectConsoleForm_Load(object sender, EventArgs e)
        {
            WriteTask();
        }
        private void BTClean_Click(object sender, EventArgs e)
        {
            RTBConsole.Text = "";
            ConsoleLine = 0;
            ConsoleLength = 0;
            UICaption(Caption);
        }
        public void AddToQueue(string s)
        {
            Lines.Enqueue(s);
        }
        private void WriteTask()
        {
            if (!IsWrite)
            {
                Task.Factory.StartNew(() =>
                {
                    IsWrite = true;
                    while (!IsDisposed)
                    {
                        if (Lines.Any() && Lines.Count > 0)
                        {
                            try
                            {
                                StringBuilder sb = new StringBuilder();
                                for (int i = 0; i < Lines.Count; i++)
                                {
                                    if (Lines.TryDequeue(out string s))
                                    {
                                        ConsoleLine++;
                                        if (CBNumber.Checked) sb.Append($"【{ConsoleLine}】");
                                        sb.Append(s);
                                        sb.Append(Environment.NewLine);

                                    }
                                }
                                if (sb.Length > 0) UIConsole(sb.ToString());
                            }
                            catch { }
                        }
                        Thread.Sleep(WriteInterval);
                    }
                });
            }
        }

        #region UI操作
        /// <summary>
        /// 修改窗口标题
        /// </summary>
        /// <param name="s"></param>
        public void UICaption(string s)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    Caption = s;
                    Text = $"{Caption} 的输出窗口    [ {ByteConvertTool.Fmt(ConsoleLength)} ]";
                }));
            }
            catch { }
        }
        /// <summary>
        /// 添加文本内容
        /// </summary>
        /// <param name="s"></param>
        private void UIConsole(string s)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    if (!CBNotWrite.Checked)
                    {
                        ConsoleLength += s.Length;//更新文本长度
                        UICaption(Caption);//更新标题，带文本长度提示 
                        RTBConsole.AppendText(s);//追加内容到文本框
                        RTBConsole.ScrollToCaret();//滚动到底部
                    }
                }));
            }
            catch { }
        }
        /// <summary>
        /// 高亮文本内容（已弃用，后期可考虑做搜索功能）
        /// </summary>
        /// <param name="length"></param>
        private void UIConsoleHighlight(int length)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    //高亮关键字
                    string[] keywords = null;
                    if (ListTool.HasElements(keywords))
                    {
                        foreach (var key in keywords)
                        {
                            if (!StringTool.Ok(key)) continue;//不正常关键字跳出

                            int start = ConsoleLength - length;
                            while ((start = RTBConsole.Text.IndexOf(key, start)) >= 0)
                            {
                                RTBConsole.Select(start, key.Length);
                                RTBConsole.SelectionBackColor = Color.Yellow;
                                start++;
                            }
                        }
                    }
                }));
            }
            catch { }
        }
        #endregion


    }
}
