using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a special object for use with the CopyObjects method that contains the object IDs of both the source and destination objects
///</summary>
namespace OdaX.AcadIdPair 
{

	[NVP_Manifest(
		Id = "703A2C45-15F9-43C7-A35E-C966266EA475", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadIdPair.AcadIdPair_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadIdPair", 
		NodeName = "_AcadIdPair_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadIdPair_Constructor : INode 
	{
		public OdaX.IAcadIdPair _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadIdPair;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "03B70BD0-7A62-40E4-B9F4-2809A7A90F36", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadIdPair.AcadIdPair_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadIdPair", 
		NodeName = "_AcadIdPair_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadIdPair_ConstructorCast : INode 
	{
		public OdaX.IAcadIdPair _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadIdPair;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "0F663964-D934-42EC-952E-A3B264E46032", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadIdPair.IsCloned", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadIdPair", 
		NodeName = "IsCloned", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines if the source object in a CopyObjects operation has been cloned", 
		ViewType = "Data")]
	[NodeInput("AcadIdPair", typeof(object))]

	///<summary>
	///Determines if the source object in a CopyObjects operation has been cloned
	///</summary>
	public class IsCloned : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsCloned);

		}
	}


	[NVP_Manifest(
		Id = "6AB5EB93-ECA1-4DA4-9625-4A9166A5828F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadIdPair.IsOwnerXlated", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadIdPair", 
		NodeName = "IsOwnerXlated", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines if the owning object in a CopyObjects operation has been translated", 
		ViewType = "Data")]
	[NodeInput("AcadIdPair", typeof(object))]

	///<summary>
	///Determines if the owning object in a CopyObjects operation has been translated
	///</summary>
	public class IsOwnerXlated : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsOwnerXlated);

		}
	}


	[NVP_Manifest(
		Id = "00B5B3E0-EDCF-42E9-AE3B-4A8E593DB8BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadIdPair.IsPrimary", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadIdPair", 
		NodeName = "IsPrimary", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines if the source object in a CopyObjects operation was part of the primary set of objects being copied, or if it was simply owned by a member in the primary set", 
		ViewType = "Data")]
	[NodeInput("AcadIdPair", typeof(object))]

	///<summary>
	///Determines if the source object in a CopyObjects operation was part of the primary set of objects being copied, or if it was simply owned by a member in the primary set
	///</summary>
	public class IsPrimary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPrimary);

		}
	}


	[NVP_Manifest(
		Id = "5B865C38-9A64-4DA5-B109-F183AA9023DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadIdPair.key", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadIdPair", 
		NodeName = "key", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "The object ID of the source object in the CopyObjects operation", 
		ViewType = "Data")]
	[NodeInput("AcadIdPair", typeof(object))]

	///<summary>
	///The object ID of the source object in the CopyObjects operation
	///</summary>
	public class key : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.key);

		}
	}


	[NVP_Manifest(
		Id = "5A4BC9B1-1D5A-4634-9368-22CF504D838C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadIdPair.Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadIdPair", 
		NodeName = "Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "The object ID of the newly created cloned object in the CopyObjects operation", 
		ViewType = "Data")]
	[NodeInput("AcadIdPair", typeof(object))]

	///<summary>
	///The object ID of the newly created cloned object in the CopyObjects operation
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value);

		}
	}


	[NVP_Manifest(
		Id = "1645D6B4-B917-4476-9E78-C0EB00AD8691", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadIdPair.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadIdPair", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Application object.", 
		ViewType = "Data")]
	[NodeInput("AcadIdPair", typeof(object))]

	///<summary>
	///Gets the Application object.
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}
}
