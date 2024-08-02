using NVP.API.Nodes;

namespace OdaX.AcadDictionary 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadDictionary_Constructor : INode 
	{
		public OdaX.IAcadDictionary _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDictionary;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadDictionary_ConstructorCast : INode 
	{
		public OdaX.IAcadDictionary _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDictionary;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies or returns the name of a dictionary.
	///</summary>
	[NodeInput("AcadDictionary", typeof(object))]
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	///<summary>
	///Specifies or returns the name of a dictionary.
	///</summary>
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1];
			return null;
		}
	}


	///<summary>
	///Adds an object to a dictionary.
	///</summary>
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Keyword", typeof(System.String))]
	[NodeInput("ObjectName", typeof(System.String))]
	public class AddObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddObject(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Returns the keyword string of an object in a dictionary.
	///</summary>
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Object", typeof(System.Object))]
	public class GetName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetName(inputs[1]));

		}
	}


	///<summary>
	///Returns an object in a dictionary using the keyword string associated with the object.
	///</summary>
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	public class GetObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObject(inputs[1]));

		}
	}


	///<summary>
	///Deletes an object from a dictionary.
	///</summary>
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	public class Remove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Remove(inputs[1]));

		}
	}


	///<summary>
	///Renames an object in a dictionary.
	///</summary>
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("OldName", typeof(System.String))]
	[NodeInput("NewName", typeof(System.String))]
	public class Rename : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rename(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Replaces an object in a dictionary with another object.
	///</summary>
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("OldName", typeof(System.String))]
	[NodeInput("pObj", typeof(System.Object))]
	public class Replace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Replace(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Returns an object in a dictionary using the index associated with the object.
	///</summary>
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1]));

		}
	}


	///<summary>
	///Returns the number of objects in a dictionary.
	///</summary>
	[NodeInput("AcadDictionary", typeof(object))]
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	///<summary>
	///Adds an XRecord object to a dictionary.
	///</summary>
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Keyword", typeof(System.String))]
	public class AddXRecord : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddXRecord(inputs[1]));

		}
	}
}
