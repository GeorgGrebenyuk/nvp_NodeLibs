using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface to provide information about entries in the File Dependency List of a drawing file
///</summary>
namespace OdaX.AcadFileDependency 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Returns the path and file name of an entry in the File Dependencies list.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependency", typeof(object))]

	///<summary>
	///Returns the path and file name of an entry in the File Dependencies list.
	///</summary>
	public class FullFileName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FullFileName);

		}
	}


	[NVP_Manifest(
		Text = "Returns the file name of an entry in the File Dependencies list.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependency", typeof(object))]

	///<summary>
	///Returns the file name of an entry in the File Dependencies list.
	///</summary>
	public class FileName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FileName);

		}
	}


	[NVP_Manifest(
		Text = "Returns the alternative path for an entry in the File Dependencies list.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependency", typeof(object))]

	///<summary>
	///Returns the alternative path for an entry in the File Dependencies list.
	///</summary>
	public class FoundPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FoundPath);

		}
	}


	[NVP_Manifest(
		Text = "Returns the fingerprint GUID for an entry in the File Dependencies list.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependency", typeof(object))]

	///<summary>
	///Returns the fingerprint GUID for an entry in the File Dependencies list.
	///</summary>
	public class FingerprintGuid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FingerprintGuid);

		}
	}


	[NVP_Manifest(
		Text = "Returns the version GUID for an entry in the File Dependencies list.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependency", typeof(object))]

	///<summary>
	///Returns the version GUID for an entry in the File Dependencies list.
	///</summary>
	public class VersionGuid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VersionGuid);

		}
	}


	[NVP_Manifest(
		Text = "Returns the feature, such as XRef, for an entry in the File Dependencies list.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependency", typeof(object))]

	///<summary>
	///Returns the feature, such as XRef, for an entry in the File Dependencies list.
	///</summary>
	public class Feature : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Feature);

		}
	}


	[NVP_Manifest(
		Text = "Returns whether the entry in the File Dependencies list has been changed.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependency", typeof(object))]

	///<summary>
	///Returns whether the entry in the File Dependencies list has been changed.
	///</summary>
	public class IsModified : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsModified);

		}
	}


	[NVP_Manifest(
		Text = "Returns whether an entry in the File Dependencies list affects graphics.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependency", typeof(object))]

	///<summary>
	///Returns whether an entry in the File Dependencies list affects graphics.
	///</summary>
	public class AffectsGraphics : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AffectsGraphics);

		}
	}


	[NVP_Manifest(
		Text = "Returns the index of an entry in the File Dependencies list.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependency", typeof(object))]

	///<summary>
	///Returns the index of an entry in the File Dependencies list.
	///</summary>
	public class Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Index);

		}
	}


	[NVP_Manifest(
		Text = "Returns the timestamp of an entry in the File Dependencies list.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependency", typeof(object))]

	///<summary>
	///Returns the timestamp of an entry in the File Dependencies list.
	///</summary>
	public class TimeStamp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TimeStamp);

		}
	}


	[NVP_Manifest(
		Text = "Returns the file size of an entry in the File Dependencies list.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependency", typeof(object))]

	///<summary>
	///Returns the file size of an entry in the File Dependencies list.
	///</summary>
	public class FileSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FileSize);

		}
	}


	[NVP_Manifest(
		Text = "Returns the reference count of an entry in the File Dependencies list.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependency", typeof(object))]

	///<summary>
	///Returns the reference count of an entry in the File Dependencies list.
	///</summary>
	public class ReferenceCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReferenceCount);

		}
	}
}
