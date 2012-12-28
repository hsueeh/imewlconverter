﻿using System;
using System.Collections.Generic;
using System.Text;
using Studyzy.IMEWLConverter.Generaters;
using Studyzy.IMEWLConverter.Helpers;

namespace Studyzy.IMEWLConverter.IME
{
    /// <summary>
    /// 极点的词库格式为“编码 词语 词语 词语”\r\n
    /// </summary>
    [ComboBoxShow(ConstantString.JIDIAN_ZHENGMA, ConstantString.JIDIAN_ZHENGMA_C, 190)]
    public class JidianZhengma : Jidian, IWordLibraryTextImport, IWordLibraryExport
    {
     

        #region IWordLibraryExport 成员

        private readonly IWordCodeGenerater factory = new ZhengmaGenerater();

        public override string ExportLine(WordLibrary wl)
        {
            var sb = new StringBuilder();
            sb.Append(factory.GetCodeOfString(wl.Word)[0]);
            sb.Append(" ");
            sb.Append(wl.Word);

            return sb.ToString();
        }

    


        #endregion

    }
}