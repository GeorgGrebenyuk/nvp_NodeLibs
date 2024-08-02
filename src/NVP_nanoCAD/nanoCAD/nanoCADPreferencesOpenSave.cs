using NVP.API.Nodes;

namespace nanoCAD.nanoCADPreferencesOpenSave 
{
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


		///<summary>
		///Gets the Application object.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}


		///<summary>
		///Specifies or returns whether thumbnail preview images are saved with drawings.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_SavePreviewThumbnail : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SavePreviewThumbnail = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether thumbnail preview images are saved with drawings.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class SavePreviewThumbnail : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SavePreviewThumbnail);

			}
		}


		///<summary>
		///Specifies or returns when a full save is performed instead of an incremental save.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		[NodeInput("Path", typeof(System.Int32))]
		public class Set_IncrementalSavePercent : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.IncrementalSavePercent = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns when a full save is performed instead of an incremental save.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class IncrementalSavePercent : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IncrementalSavePercent);

			}
		}


		///<summary>
		///Specifies or returns how often drawings are saved automatically.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		[NodeInput("Path", typeof(System.Int32))]
		public class Set_AutoSaveInterval : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AutoSaveInterval = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns how often drawings are saved automatically.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class AutoSaveInterval : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AutoSaveInterval);

			}
		}


		///<summary>
		///Specifies or returns whether backup files are saved.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		[NodeInput("CreateBackup", typeof(System.Object))]
		public class Set_CreateBackup : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.CreateBackup = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether backup files are saved.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class CreateBackup : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateBackup);

			}
		}


		///<summary>
		///Specifies or returns whether checking is turned on when hardware or software errors are suspected.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_FullCRCValidation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.FullCRCValidation = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether checking is turned on when hardware or software errors are suspected.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class FullCRCValidation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FullCRCValidation);

			}
		}


		///<summary>
		///Specifies or returns whether a log file is saved to capture text window contents.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_LogFileOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LogFileOn = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether a log file is saved to capture text window contents.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class LogFileOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LogFileOn);

			}
		}


		///<summary>
		///Specifies or returns the file extension used for temporary files.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_TempFileExtension : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TempFileExtension = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the file extension used for temporary files.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class TempFileExtension : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TempFileExtension);

			}
		}


		///<summary>
		///Specifies or returns how external references are loaded.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_XrefDemandLoad : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.XrefDemandLoad = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns how external references are loaded.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class XrefDemandLoad : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.XrefDemandLoad);

			}
		}


		///<summary>
		///Specifies or returns how third-party applications are loaded if a drawing contains custom objects created in that application.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_DemandLoadARXApp : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DemandLoadARXApp = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns how third-party applications are loaded if a drawing contains custom objects created in that application.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class DemandLoadARXApp : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DemandLoadARXApp);

			}
		}


		///<summary>
		///Specifies or returns how objects that were created in a third-party application display in a drawing.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_ProxyImage : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ProxyImage = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns how objects that were created in a third-party application display in a drawing.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class ProxyImage : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ProxyImage);

			}
		}


		///<summary>
		///Specifies or returns whether a warning displays when opening a drawing that contains custom objects.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_ShowProxyDialogBox : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShowProxyDialogBox = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether a warning displays when opening a drawing that contains custom objects.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class ShowProxyDialogBox : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShowProxyDialogBox);

			}
		}


		///<summary>
		///Specifies or returns whether an audit is performed after you render a DXFIN or DXBIN interchange command.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		[NodeInput("bAudit", typeof(System.Object))]
		public class Set_AutoAudit : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AutoAudit = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether an audit is performed after you render a DXFIN or DXBIN interchange command.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class AutoAudit : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AutoAudit);

			}
		}


		///<summary>
		///Specifies or returns the default drawing type used for saving drawings.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_SaveAsType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SaveAsType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the default drawing type used for saving drawings.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class SaveAsType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SaveAsType);

			}
		}


		///<summary>
		///Specifies the number of recent files to track on the File menu.
		///</summary>
		[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
		public class MRUNumber : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MRUNumber);

			}
		}
}
