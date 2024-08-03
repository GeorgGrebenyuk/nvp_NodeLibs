using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for creating, updating, retrieving and removing items in the File Dependency List
///</summary>
namespace OdaX.AcadFileDependencies 
{

	[NVP_Manifest(
		Id = "E98ED47D-5D9C-434D-9EAF-6F44B5E1261A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependencies.AcadFileDependencies_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependencies", 
		NodeName = "_AcadFileDependencies_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadFileDependencies_Constructor : INode 
	{
		public OdaX.IAcadFileDependencies _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadFileDependencies;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "CDF4069C-C0CB-4750-A1A2-A230EB98533C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependencies.AcadFileDependencies_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependencies", 
		NodeName = "_AcadFileDependencies_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadFileDependencies_ConstructorCast : INode 
	{
		public OdaX.IAcadFileDependencies _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadFileDependencies;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "425A5439-8540-4F95-B3F3-AF0EBCAA5890", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependencies.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependencies", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns an object at a given index in the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependencies", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object at a given index in the collection.
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "75985B3E-82B8-4B4C-823B-EE2145BE2435", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependencies.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependencies", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependencies", typeof(object))]

	///<summary>
	///Returns the Application object.
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Id = "7E0EF53A-9B61-4369-A46A-DB5E6A7B325A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependencies.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependencies", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of items in the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependencies", typeof(object))]

	///<summary>
	///Returns the number of items in the collection.
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Id = "818FC499-23AD-43A9-831A-874E837B3E01", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependencies.CreateEntry", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependencies", 
		NodeName = "CreateEntry", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an entry in the File Dependencis list.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependencies", typeof(object))]
	[NodeInput("Feature", typeof(System.String))]
	[NodeInput("FullFileName", typeof(System.String))]
	[NodeInput("AffectsGraphics", typeof(System.Object))]
	[NodeInput("noIncrement", typeof(System.Object))]

	///<summary>
	///Creates an entry in the File Dependencis list.
	///</summary>
	public class CreateEntry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateEntry(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "023F359B-C6EC-4CDD-B4E8-41FE4033D12B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependencies.IndexOf", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependencies", 
		NodeName = "IndexOf", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the index in the collection of a specified entry.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependencies", typeof(object))]
	[NodeInput("Feature", typeof(System.String))]
	[NodeInput("FullFileName", typeof(System.String))]

	///<summary>
	///Returns the index in the collection of a specified entry.
	///</summary>
	public class IndexOf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IndexOf(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "C6765EFE-E3AD-41B8-80F7-62504898B549", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependencies.RemoveEntry", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependencies", 
		NodeName = "RemoveEntry", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Removes an entry from the File Dependencies list.", 
		ViewType = "Modifier")]
	[NodeInput("AcadFileDependencies", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("forceRemove", typeof(System.Object))]

	///<summary>
	///Removes an entry from the File Dependencies list.
	///</summary>
	public class RemoveEntry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveEntry(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "93E34598-59A6-4E96-9C6F-CE7878907695", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadFileDependencies.UpdateEntry", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadFileDependencies", 
		NodeName = "UpdateEntry", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Updates an entry in the File Dependencies list.", 
		ViewType = "Modifier")]
	[NodeInput("AcadFileDependencies", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Updates an entry in the File Dependencies list.
	///</summary>
	public class UpdateEntry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UpdateEntry(inputs[1].Value);
			return null;
		}
	}
}
