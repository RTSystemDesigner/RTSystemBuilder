using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RTSystemBuilder {
  public enum AppStatus {
    TOP_MENU,
    COMP_DB,
    SYSTEM_EDIT,
    WASANBON_EDIT,
    WASANBON_REGIST,
    END
  }
  public class CompDB_Const {
    internal static readonly string TOOL_NAME = "Component Database";

    internal const uint LANG_CPP = 1;
    internal const uint LANG_PYTHON = 2;
    internal const uint LANG_JAVA = 3;

    internal static readonly uint DP_IN = 1;
    internal static readonly uint DP_OUT = 2;

    internal const uint SP_PROVIDED = 1;
    internal const uint SP_REQUIRED = 2;

    internal static readonly uint STATUS_OK = 0;
    internal static readonly uint STATUS_NG = 1;
  }
  public class Color_Const {
    internal static Color BTN_BG_ENABLE = Color.FromArgb(255, 174, 251, 217);
    internal static Color BTN_BG_DISABLE = Color.FromArgb(255, 154, 231, 241);
  }
}
