using NVP.API.Nodes;

namespace OdaX.AcadFileDependency 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadFileDependency_Constructor : INode 
	{
		public OdaX.IAcadFileDependency _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadFileDependency;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadFileDependency_ConstructorCast : INode 
	{
		public OdaX.IAcadFileDependency _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadFileDependency;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Returns the path and file name of an entry in the File Dependencies list.
	///</summary>
	[NodeInput("AcadFileDependency", typeof(object))]
	public class FullFileName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FullFileName);

		}
	}


	///<summary>
	///Returns the file name of an entry in the File Dependencies list.
	///</summary>
	[NodeInput("AcadFileDependency", typeof(object))]
	public class FileName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FileName);

		}
	}


	///<summary>
	///Returns the alternative path for an entry in the File Dependencies list.
	///</summary>
	[NodeInput("AcadFileDependency", typeof(object))]
	public class FoundPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FoundPath);

		}
	}


	///<summary>
	///Returns the fingerprint GUID for an entry in the File Dependencies list.
	///</summary>
	[NodeInput("AcadFileDependency", typeof(object))]
	public class FingerprintGuid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FingerprintGuid);

		}
	}


	///<summary>
	///Returns the version GUID for an entry in the File Dependencies list.
	///</summary>
	[NodeInput("AcadFileDependency", typeof(object))]
	public class VersionGuid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VersionGuid);

		}
	}


	///<summary>
	///Returns the feature, such as XRef, for an entry in the File Dependencies list.
	///</summary>
	[NodeInput("AcadFileDependency", typeof(object))]
	public class Feature : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Feature);

		}
	}


	///<summary>
	///Returns whether the entry in the File Dependencies list has been changed.
	///</summary>
	[NodeInput("AcadFileDependency", typeof(object))]
	public class IsModified : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsModified);

		}
	}


	///<summary>
	///Returns whether an entry in the File Dependencies list affects graphics.
	///</summary>
	[NodeInput("AcadFileDependency", typeof(object))]
	public class AffectsGraphics : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AffectsGraphics);

		}
	}


	///<summary>
	///Returns the index of an entry in the File Dependencies list.
	///</summary>
	[NodeInput("AcadFileDependency", typeof(object))]
	public class Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Index);

		}
	}


	///<summary>
	///Returns the timestamp of an entry in the File Dependencies list.
	///</summary>
	[NodeInput("AcadFileDependency", typeof(object))]
	public class TimeStamp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TimeStamp);

		}
	}


	///<summary>
	///Returns the file size of an entry in the File Dependencies list.
	///</summary>
	[NodeInput("AcadFileDependency", typeof(object))]
	public class FileSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FileSize);

		}
	}


	///<summary>
	///Returns the reference count of an entry in the File Dependencies list.
	///</summary>
	[NodeInput("AcadFileDependency", typeof(object))]
	public class ReferenceCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReferenceCount);

		}
	}
}
