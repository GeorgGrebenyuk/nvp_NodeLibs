using NVP.API.Nodes;

namespace nanoCAD.Arguments 
{
		[NodeInput("dynamic", typeof(object))]
		public class Arguments_Constructor : INode 
		{
		public nanoCAD.IArguments _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as nanoCAD.IArguments;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Arguments_ConstructorCast : INode 
		{
		public nanoCAD.IArguments _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as nanoCAD.IArguments;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Retrieves the string from container
		///</summary>
		[NodeInput("Arguments", typeof(object))]
		[NodeInput("idx", typeof(System.Object))]
		public class Item : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Item(inputs[1]));

			}
		}


		///<summary>
		///Retrieves the string from container
		///</summary>
		[NodeInput("Arguments", typeof(object))]
		[NodeInput("idx", typeof(System.Object))]
		[NodeInput("str", typeof(System.String))]
		public class Set_Item : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Item[inputs[1]] = inputs[2];
				return null;
			}
		}


		///<summary>
		///Gets the number of commands in assembly
		///</summary>
		[NodeInput("Arguments", typeof(object))]
		public class Count : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Count);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Arguments", typeof(object))]
		public class Append : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Append();
				return null;
			}
		}
}
