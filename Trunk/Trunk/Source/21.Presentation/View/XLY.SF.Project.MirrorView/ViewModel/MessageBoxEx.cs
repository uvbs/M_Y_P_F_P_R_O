﻿using System;
using System.Windows;
using XLY.SF.Framework.Core.Base.CoreInterface;
using XLY.SF.Framework.Core.Base.MefIoc;

/* ==============================================================================
* Description：MessageBoxEx  
* Author     ：litao
* Create Date：2017/11/16 9:54:37
* ==============================================================================*/

namespace XLY.SF.Project.MirrorView
{
    class MessageBoxEx : IMessageBox
    {
        IMessageBox _msgBox;
        public MessageBoxEx()
        {
            bool isToolRun = Application.Current is App;
            if (!isToolRun)
            {
                _msgBox = IocManagerSingle.Instance.GetPart<IMessageBox>();
            }
        }

        public bool ShowDialogErrorMsg(string errorText)
        {
            if (_msgBox != null)
            {
                return _msgBox.ShowDialogErrorMsg(errorText);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(errorText, "提示");
                return result == MessageBoxResult.OK;
            }
        }

        public bool ShowDialogWarningMsg(string text)
        {
            if (_msgBox != null)
            {
                return _msgBox.ShowDialogWarningMsg(text);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(text, "提示");
                return result == MessageBoxResult.OK;
            }
        }
        public void ShowErrorMsg(string errorText)
        {
            if (_msgBox != null)
            {
                _msgBox.ShowErrorMsg(errorText);
            }
            else
            {
                MessageBox.Show(errorText, "提示");
            }
        }

        public bool ShowSuccessMsg(string title, string text)
        {
            if (_msgBox != null)
            {
                return _msgBox.ShowDialogSuccessMsg(text);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(text, title);
                return result == MessageBoxResult.OK;
            }
        }

        public bool ShowDialogSuccessMsg(string text)
        {
            if (_msgBox != null)
            {
                return _msgBox.ShowDialogSuccessMsg(text);
            }
            else
            {
                return MessageBox.Show(text, "提示") == MessageBoxResult.OK;
            }
        }

        //public void ShowWarningMsg(string title, string text)
        //{
        //    if (_msgBox != null)
        //    {
        //        _msgBox.ShowWarningMsg(text);
        //    }
        //    else
        //    {
        //        MessageBox.Show(text, title);
        //    }
        //}

        public void ShowWarningMsg(string warningText)
        {
            if (_msgBox != null)
            {
                _msgBox.ShowWarningMsg(warningText);
            }
            else
            {
                MessageBox.Show(warningText, "警告");
            }
        }

        public void ShowSuccessMsg(string successText)
        {
            if (_msgBox != null)
            {
                _msgBox.ShowSuccessMsg(successText);
            }
            else
            {
                MessageBox.Show(successText, "成功");
            }
        }
    }
}
