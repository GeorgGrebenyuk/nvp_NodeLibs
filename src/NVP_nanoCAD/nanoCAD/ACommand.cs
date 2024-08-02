using NVP.API.Nodes;

namespace nanoCAD.ACommand 
{
		[NodeInput("dynamic", typeof(object))]
		public class ACommand_Constructor : INode 
		{
		public nanoCAD.IACommand _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as nanoCAD.IACommand;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ACommand_ConstructorCast : INode 
		{
		public nanoCAD.IACommand _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as nanoCAD.IACommand;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///command type
		///</summary>
		[NodeInput("ACommand", typeof(object))]
		public class Type : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Type);

			}
		}


		///<summary>
		///command type
		///</summary>
		[NodeInput("ACommand", typeof(object))]
		public class ID : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ID);

			}
		}


		///<summary>
		///command type
		///</summary>
		[NodeInput("ACommand", typeof(object))]
		[NodeInput("ID", typeof(System.Object))]
		public class Set_ID : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ID = inputs[1];
				return null;
			}
		}


		///<summary>
		///internal name
		///</summary>
		[NodeInput("ACommand", typeof(object))]
		public class InternalName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.InternalName);

			}
		}


		///<summary>
		///disp name
		///</summary>
		[NodeInput("ACommand", typeof(object))]
		public class DispName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DispName);

			}
		}


		///<summary>
		///weight
		///</summary>
		[NodeInput("ACommand", typeof(object))]
		public class Weight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Weight);

			}
		}


		///<summary>
		///launch weight
		///</summary>
		[NodeInput("ACommand", typeof(object))]
		public class LaunchWeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LaunchWeight);

			}
		}


		///<summary>
		///StatusString
		///</summary>
		[NodeInput("ACommand", typeof(object))]
		public class StatusString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StatusString);

			}
		}


		///<summary>
		///tooltip string
		///</summary>
		[NodeInput("ACommand", typeof(object))]
		public class ToolTip : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ToolTip);

			}
		}


		///<summary>
		///caps
		///</summary>
		[NodeInput("ACommand", typeof(object))]
		public class Caps : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Caps);

			}
		}


		///<summary>
		///menu string
		///</summary>
		[NodeInput("ACommand", typeof(object))]
		public class MenuText : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MenuText);

			}
		}


		///<summary>
		///menu group
		///</summary>
		[NodeInput("ACommand", typeof(object))]
		public class MenuGroup : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MenuGroup);

			}
		}


		///<summary>
		///Run command
		///</summary>
		[NodeInput("ACommand", typeof(object))]
		[NodeInput("helper", typeof(System.Object))]
		public class Run : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Run(inputs[1]);
				return null;
			}
		}
}
