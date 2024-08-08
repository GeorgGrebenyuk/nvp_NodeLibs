using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Specifies open and save settings.
///</summary>
namespace nanoCAD.nanoCADPreferencesOpenSave 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesOpenSave_Constructor : INode 
	{
		public nanoCAD.InanoCADPreferencesOpenSave _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPreferencesOpenSave;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesOpenSave_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPreferencesOpenSave _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPreferencesOpenSave;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Gets the Application object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Gets the Application object.
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether thumbnail preview images are saved with drawings.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether thumbnail preview images are saved with drawings.
	///</summary>
	public class Set_SavePreviewThumbnail : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SavePreviewThumbnail = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether thumbnail preview images are saved with drawings.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns whether thumbnail preview images are saved with drawings.
	///</summary>
	public class SavePreviewThumbnail : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SavePreviewThumbnail);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns when a full save is performed instead of an incremental save.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("Path", typeof(System.Int32))]

	///<summary>
	///Specifies or returns when a full save is performed instead of an incremental save.
	///</summary>
	public class Set_IncrementalSavePercent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IncrementalSavePercent = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns when a full save is performed instead of an incremental save.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns when a full save is performed instead of an incremental save.
	///</summary>
	public class IncrementalSavePercent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IncrementalSavePercent);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how often drawings are saved automatically.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("Path", typeof(System.Int32))]

	///<summary>
	///Specifies or returns how often drawings are saved automatically.
	///</summary>
	public class Set_AutoSaveInterval : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSaveInterval = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how often drawings are saved automatically.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns how often drawings are saved automatically.
	///</summary>
	public class AutoSaveInterval : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSaveInterval);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether backup files are saved.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("CreateBackup", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether backup files are saved.
	///</summary>
	public class Set_CreateBackup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CreateBackup = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether backup files are saved.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns whether backup files are saved.
	///</summary>
	public class CreateBackup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateBackup);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether checking is turned on when hardware or software errors are suspected.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether checking is turned on when hardware or software errors are suspected.
	///</summary>
	public class Set_FullCRCValidation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FullCRCValidation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether checking is turned on when hardware or software errors are suspected.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns whether checking is turned on when hardware or software errors are suspected.
	///</summary>
	public class FullCRCValidation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FullCRCValidation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a log file is saved to capture text window contents.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a log file is saved to capture text window contents.
	///</summary>
	public class Set_LogFileOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LogFileOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a log file is saved to capture text window contents.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns whether a log file is saved to capture text window contents.
	///</summary>
	public class LogFileOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LogFileOn);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the file extension used for temporary files.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the file extension used for temporary files.
	///</summary>
	public class Set_TempFileExtension : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TempFileExtension = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the file extension used for temporary files.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns the file extension used for temporary files.
	///</summary>
	public class TempFileExtension : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TempFileExtension);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how external references are loaded.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("nanoCAD.AcXRefDemandLoad", typeof(System.Object))]

	///<summary>
	///Specifies or returns how external references are loaded.
	///</summary>
	public class Set_XrefDemandLoad : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XrefDemandLoad = ((nanoCAD.AcXRefDemandLoad)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how external references are loaded.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns how external references are loaded.
	///</summary>
	public class XrefDemandLoad : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XrefDemandLoad);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how third-party applications are loaded if a drawing contains custom objects created in that application.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("nanoCAD.AcARXDemandLoad", typeof(System.Object))]

	///<summary>
	///Specifies or returns how third-party applications are loaded if a drawing contains custom objects created in that application.
	///</summary>
	public class Set_DemandLoadARXApp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DemandLoadARXApp = ((nanoCAD.AcARXDemandLoad)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how third-party applications are loaded if a drawing contains custom objects created in that application.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns how third-party applications are loaded if a drawing contains custom objects created in that application.
	///</summary>
	public class DemandLoadARXApp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DemandLoadARXApp);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how objects that were created in a third-party application display in a drawing.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("nanoCAD.AcProxyImage", typeof(System.Object))]

	///<summary>
	///Specifies or returns how objects that were created in a third-party application display in a drawing.
	///</summary>
	public class Set_ProxyImage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProxyImage = ((nanoCAD.AcProxyImage)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how objects that were created in a third-party application display in a drawing.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns how objects that were created in a third-party application display in a drawing.
	///</summary>
	public class ProxyImage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProxyImage);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a warning displays when opening a drawing that contains custom objects.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a warning displays when opening a drawing that contains custom objects.
	///</summary>
	public class Set_ShowProxyDialogBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowProxyDialogBox = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a warning displays when opening a drawing that contains custom objects.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns whether a warning displays when opening a drawing that contains custom objects.
	///</summary>
	public class ShowProxyDialogBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowProxyDialogBox);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether an audit is performed after you render a DXFIN or DXBIN interchange command.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("bAudit", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether an audit is performed after you render a DXFIN or DXBIN interchange command.
	///</summary>
	public class Set_AutoAudit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoAudit = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether an audit is performed after you render a DXFIN or DXBIN interchange command.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns whether an audit is performed after you render a DXFIN or DXBIN interchange command.
	///</summary>
	public class AutoAudit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoAudit);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the default drawing type used for saving drawings.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("nanoCAD.AcSaveAsType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the default drawing type used for saving drawings.
	///</summary>
	public class Set_SaveAsType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveAsType = ((nanoCAD.AcSaveAsType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the default drawing type used for saving drawings.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns the default drawing type used for saving drawings.
	///</summary>
	public class SaveAsType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SaveAsType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the number of recent files to track on the File menu.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies the number of recent files to track on the File menu.
	///</summary>
	public class MRUNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MRUNumber);

		}
	}
}
