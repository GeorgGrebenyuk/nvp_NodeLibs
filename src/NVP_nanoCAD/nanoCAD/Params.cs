using NVP.API.Nodes;

namespace nanoCAD.Params 
{
	[NodeInput("dynamic", typeof(object))]
	public class Params_Constructor : INode 
	{
		public nanoCAD.IParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.IParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class Params_ConstructorCast : INode 
	{
		public nanoCAD.IParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.IParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Sets new section
	///</summary>
	[NodeInput("Params", typeof(object))]
	[NodeInput("Path", typeof(System.String))]
	[NodeInput("create", typeof(System.Object))]
	[NodeInput("Section", typeof(System.Object))]
	public class Set_Section : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Section[inputs[1]] = inputs[2];
			return null;
		}
	}


	///<summary>
	///Sets new section
	///</summary>
	[NodeInput("Params", typeof(object))]
	[NodeInput("Path", typeof(System.String))]
	[NodeInput("create", typeof(System.Object))]
	public class Section : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Section(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Returns the subsections names enumerator
	///</summary>
	[NodeInput("Params", typeof(object))]
	public class Sections : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Sections);

		}
	}


	///<summary>
	///Returns the value of named value
	///</summary>
	[NodeInput("Params", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Type", typeof(System.Object))]
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Returns the value of named value
	///</summary>
	[NodeInput("Params", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Type", typeof(System.Object))]
	[NodeInput("pValue", typeof(System.Object))]
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value[inputs[1]] = inputs[2];
			return null;
		}
	}


	///<summary>
	///Returns the values names enumerator
	///</summary>
	[NodeInput("Params", typeof(object))]
	public class Values : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Values);

		}
	}


	///<summary>
	///Retrieves text
	///</summary>
	[NodeInput("Params", typeof(object))]
	[NodeInput("format", typeof(System.Object))]
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text(inputs[1]));

		}
	}


	///<summary>
	///Retrieves text
	///</summary>
	[NodeInput("Params", typeof(object))]
	[NodeInput("format", typeof(System.Object))]
	[NodeInput("Text", typeof(System.String))]
	public class Set_Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Text[inputs[1]] = inputs[2];
			return null;
		}
	}
}
