using NVP.API.Nodes;

namespace nanoCAD.ALoader 
{
		[NodeInput("dynamic", typeof(object))]
		public class ALoader_Constructor : INode 
		{
		public nanoCAD.IALoader _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as nanoCAD.IALoader;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ALoader_ConstructorCast : INode 
		{
		public nanoCAD.IALoader _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as nanoCAD.IALoader;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Retrieves the command item from assembly
		///</summary>
		[NodeInput("ALoader", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
		public class Item : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Item(inputs[1]));

			}
		}


		///<summary>
		///Gets the number of commands in assembly
		///</summary>
		[NodeInput("ALoader", typeof(object))]
		public class Count : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Count);

			}
		}


		///<summary>
		///Loads the assembly
		///</summary>
		[NodeInput("ALoader", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Load : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Load(inputs[1]);
				return null;
			}
		}


		///<summary>
		///unLoads the assembly
		///</summary>
		[NodeInput("ALoader", typeof(object))]
		public class Unload : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Unload();
				return null;
			}
		}
}
