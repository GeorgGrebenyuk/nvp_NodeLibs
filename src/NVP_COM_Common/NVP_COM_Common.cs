using Microsoft.Win32;
using NVP.API.Nodes;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Versioning;
using System.Security;
using System.Text;
using System.Linq;
using System.Diagnostics;
using NVP_Manifest_Creator;

namespace NVP_COM_Common
{
    /// <summary>
    /// Get _i object (COM-interface)
    /// </summary>
    [NVP_Manifest(
    Id = "BEF5FB18-6C25-4FEC-80ED-989FA1DD9036",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_GetInterface",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common",
    NodeName = "GetInterface",
    NodeType = "Loaded",
    CADType = "None",
    Text = "Get _i object (COM-interface)",
    ViewType = "Modifier")]
    [NodeInput("dynamic", typeof(object))]
    public class NVP_COM_GetInterface : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            return new NodeResult(_input0._i);
        }
    }

    /// <summary>
    /// Get COM processes ID
    /// </summary>
    [NVP_Manifest(
    Id = "CD4A7926-7820-4ABC-92C4-B0C8D4A1EA9F",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_GetROT",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common",
    NodeName = "GetROT",
    NodeType = "Loaded",
    CADType = "None",
    Text = "Get COM (Running Object Table) processes ID",
    ViewType = "Modifier")]
    public class NVP_COM_GetROT : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            List<string> processes = new List<string>();
            foreach (var moniker in EnumRunningObjects())
            {
                List<string> t1 = GetMonikerString(moniker).Split('\t').ToList();
                processes = processes.Concat(t1).ToList();
            }
            return new NodeResult(processes);
        }

        #region getting_processes_ROT
        //https://stackoverflow.com/questions/7736280/marshal-getactiveobject-throws-mk-e-unavailable-exception-in-c-sharp
        private const int S_OK = 0x00000000;

        [DllImport("ole32.dll")]
        private static extern int GetRunningObjectTable(uint reserved, out IRunningObjectTable pprot);

        [DllImport("ole32.dll")]
        private static extern int CreateBindCtx(uint reserved, out IBindCtx ppbc);

        private static void OleCheck(string message, int result)
        {
            if (result != S_OK)
                throw new COMException(message, result);
        }

        private static System.Collections.Generic.IEnumerable<IMoniker> EnumRunningObjects()
        {
            IRunningObjectTable objTbl;
            OleCheck("GetRunningObjectTable failed", GetRunningObjectTable(0, out objTbl));
            IEnumMoniker enumMoniker;
            IMoniker[] monikers = new IMoniker[1];
            objTbl.EnumRunning(out enumMoniker);
            enumMoniker.Reset();
            while (enumMoniker.Next(1, monikers, IntPtr.Zero) == S_OK)
            {
                yield return monikers[0];
            }
        }

        private static bool TryGetCLSIDFromDisplayName(string displayName, out string clsid)
        {
            var bBracket = displayName.IndexOf("{");
            var eBracket = displayName.IndexOf("}");
            if ((bBracket > 0) && (eBracket > 0) && (eBracket > bBracket))
            {
                clsid = displayName.Substring(bBracket, eBracket - bBracket + 1);
                return true;
            }
            else
            {
                clsid = string.Empty;
                return false;
            }
        }

        private static string ReadSubKeyValue(string keyName, RegistryKey key)
        {
            var subKey = key.OpenSubKey(keyName);
            if (subKey != null)
            {
                using (subKey)
                {
                    var value = subKey.GetValue("");
                    return value == null ? string.Empty : value.ToString();
                }
            }
            return string.Empty;
        }

        private static string GetMonikerString(IMoniker moniker)
        {
            IBindCtx ctx;
            OleCheck("CreateBindCtx failed", CreateBindCtx(0, out ctx));
            var sb = new StringBuilder();
            string displayName;
            moniker.GetDisplayName(ctx, null, out displayName);
            sb.Append(displayName);
            sb.Append('\t');
            string clsid;
            if (TryGetCLSIDFromDisplayName(displayName, out clsid))
            {
                var regClass = Registry.ClassesRoot.OpenSubKey("\\CLSID\\" + clsid);
                if (regClass != null)
                {
                    using (regClass)
                    {
                        sb.Append(regClass.GetValue(""));
                        sb.Append('\t');
                        sb.Append(ReadSubKeyValue("ProgID", regClass));
                        sb.Append('\t');
                        sb.Append(ReadSubKeyValue("LocalServer32", regClass));
                    }
                }
            }
            return sb.ToString();
        }
        #endregion
    }

    /// <summary>
    /// Check input object of null
    /// </summary>
    [NodeInput("dynamic", typeof(object))]
    [NVP_Manifest(
    Id = "56A96CF6-4D48-4549-A7CA-1F0A8595DF14",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_IsNull",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common",
    NodeName = "IsNull",
    NodeType = "Loaded",
    CADType = "None",
    Text = "Check input object of null",
    ViewType = "Modifier")]
    public class NVP_COM_IsNull : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            return new NodeResult(_input0 ?? null);
        }
    }


    /// <summary>
    /// Create an instance of COM interface by it's ProgID or getting existing (for applications and COM-servers)
    /// </summary>
    [NodeInput("ProgID", typeof(System.String))]
    [NVP_Manifest(
    Id = "9B8B645A-E1EC-40FA-A201-0109D562691D",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_CreateInstance",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common",
    NodeName = "CreateInstance",
    NodeType = "Loaded",
    CADType = "None",
    Text = "Create an instance of COM interface by it's ProgID or getting existing (for applications and COM-servers)",
    ViewType = "Modifier")]
    public class NVP_COM_CreateInstance : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            string _input0_ProgId = inputs[0].Value as String;
            dynamic created_app = Marshal2.GetActiveObject(_input0_ProgId);
            return new NodeResult(created_app);
        }
    }


}
