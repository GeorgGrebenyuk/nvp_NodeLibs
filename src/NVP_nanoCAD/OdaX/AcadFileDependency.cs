using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface to provide information about entries in the File Dependency List of a drawing file
///</summary>
namespace OdaX.AcadFileDependency 
{

	[NVP_Manifest(
		Id = "D99924F7-D288-4E88-8F42-1FE25B0B89A5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependency.AcadFileDependency_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependency", 
		NodeName = "_AcadFileDependency_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "70000B6A-C99E-4752-9CE7-6605747E0962", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependency.AcadFileDependency_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependency", 
		NodeName = "_AcadFileDependency_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "C957941B-029E-4EA0-B421-5CEAAF5A8805", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependency.FullFileName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependency", 
		NodeName = "FullFileName", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "14816A72-B7C2-4926-8D0E-58913E942946", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependency.FileName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependency", 
		NodeName = "FileName", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "FFF50786-D6CD-4B40-A87E-E8B7DA4A7649", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependency.FoundPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependency", 
		NodeName = "FoundPath", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "62AF7629-5D2C-4C8C-83C8-1A91A864F144", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependency.FingerprintGuid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependency", 
		NodeName = "FingerprintGuid", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "2351EF6C-943B-4E7E-9C4C-E1E9B3F911A2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependency.VersionGuid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependency", 
		NodeName = "VersionGuid", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "484EB8BA-6D23-4582-AFCC-22BF49FF6946", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependency.Feature", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependency", 
		NodeName = "Feature", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "CEF9DE41-8B80-4D5A-BEF8-417CFBD697CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependency.IsModified", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependency", 
		NodeName = "IsModified", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "1D433FDE-CC94-49DD-A125-9C7C1DC81AB8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependency.AffectsGraphics", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependency", 
		NodeName = "AffectsGraphics", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "85143640-A6A7-4944-B582-2EDD2164108D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependency.Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependency", 
		NodeName = "Index", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "5D597E3D-ED5A-4E7C-BD20-76822153CF88", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependency.TimeStamp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependency", 
		NodeName = "TimeStamp", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "FF13CC21-F585-4C13-86C1-6F42ECE6B38E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependency.FileSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependency", 
		NodeName = "FileSize", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "9AD03BC2-F3D0-48A4-94F3-2594D83067F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependency.ReferenceCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependency", 
		NodeName = "ReferenceCount", 
		NodeType = "Loaded", 
		CADType = "None", 
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
