using NVP.API.Nodes;

namespace Renga.Application 
{
		[NodeInput("dynamic", typeof(object))]
		public class Application_Constructor : INode 
		{
		public Renga.IApplication _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IApplication;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Application_ConstructorCast : INode 
		{
		public Renga.IApplication _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IApplication;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class Enable : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Enable();
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class Disable : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Disable();
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		[NodeInput("pEnabled", typeof(System.Object))]
		public class Set_Enabled : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Enabled = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class Enabled : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Enabled);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class GetMainWindowHandle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetMainWindowHandle);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class ActiveView : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ActiveView);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class UI : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UI);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class HasProject : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HasProject);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class Project : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Project);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class Selection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Selection);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class GetCurrentLocale : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetCurrentLocale);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class CreateProject : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateProject);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		[NodeInput("fileName", typeof(System.String))]
		public class CreateProjectFromTemplate : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateProjectFromTemplate(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		[NodeInput("fileName", typeof(System.String))]
		public class ImportIfcProject : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ImportIfcProject(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		[NodeInput("fileName", typeof(System.String))]
		public class OpenProject : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.OpenProject(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		[NodeInput("discardChanges", typeof(System.Object))]
		public class CloseProject : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CloseProject(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class Quit : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Quit();
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class Visible : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Visible);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		[NodeInput("pVisible", typeof(System.Object))]
		public class Set_Visible : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Visible = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class CreateIfcExportSettings : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateIfcExportSettings);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Application", typeof(object))]
		public class Version : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Version);

			}
		}
}
