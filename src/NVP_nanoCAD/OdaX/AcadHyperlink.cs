using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a URL and URL description
///</summary>
namespace OdaX.AcadHyperlink 
{

	[NVP_Manifest(
		Id = "BAB8C4EE-1A53-4057-8370-C30C97C7B4CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlink.AcadHyperlink_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlink", 
		NodeName = "_AcadHyperlink_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadHyperlink_Constructor : INode 
	{
		public OdaX.IAcadHyperlink _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadHyperlink;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "861023B2-F83C-4347-A8DA-B5CB33E02CA2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlink.AcadHyperlink_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlink", 
		NodeName = "_AcadHyperlink_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadHyperlink_ConstructorCast : INode 
	{
		public OdaX.IAcadHyperlink _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadHyperlink;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "EF05BA62-B8AE-4027-9D7C-DCB5AAEFB0E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlink.Set_URL", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlink", 
		NodeName = "Set_URL", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a link to an external file.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHyperlink", typeof(object))]
	[NodeInput("URLPath", typeof(System.String))]

	///<summary>
	///Specifies or returns a link to an external file.
	///</summary>
	public class Set_URL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.URL = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "31DE6386-8FF6-4234-AC19-A9A3E8DDFEC6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlink.URL", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlink", 
		NodeName = "URL", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a link to an external file.", 
		ViewType = "Data")]
	[NodeInput("AcadHyperlink", typeof(object))]

	///<summary>
	///Specifies or returns a link to an external file.
	///</summary>
	public class URL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.URL);

		}
	}


	[NVP_Manifest(
		Id = "CBE458DB-DB6C-4367-94CC-91BA3DF5E159", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlink.Set_URLDescription", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlink", 
		NodeName = "Set_URLDescription", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a text description of the URL.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHyperlink", typeof(object))]
	[NodeInput("Description", typeof(System.String))]

	///<summary>
	///Specifies or returns a text description of the URL.
	///</summary>
	public class Set_URLDescription : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.URLDescription = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "855AB64E-F1BF-4FDC-8651-1E052F94564C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlink.URLDescription", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlink", 
		NodeName = "URLDescription", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a text description of the URL.", 
		ViewType = "Data")]
	[NodeInput("AcadHyperlink", typeof(object))]

	///<summary>
	///Specifies or returns a text description of the URL.
	///</summary>
	public class URLDescription : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.URLDescription);

		}
	}


	[NVP_Manifest(
		Id = "8D0E662E-09D2-49F5-93F5-260CCF7FCB2F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlink.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlink", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("AcadHyperlink", typeof(object))]

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
		Id = "6672B19C-D9C2-47B8-9F50-381837DEB231", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlink.Delete", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlink", 
		NodeName = "Delete", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes a specified object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHyperlink", typeof(object))]

	///<summary>
	///Deletes a specified object.
	///</summary>
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "286698F0-C907-4F10-87E5-D66A4305D876", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlink.Set_URLNamedLocation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlink", 
		NodeName = "Set_URLNamedLocation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the named location within a file that is referenced by a URL.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHyperlink", typeof(object))]
	[NodeInput("Location", typeof(System.String))]

	///<summary>
	///Specifies or returns the named location within a file that is referenced by a URL.
	///</summary>
	public class Set_URLNamedLocation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.URLNamedLocation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DB5EA105-E996-4F2D-BE9B-1C4BD2F81749", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlink.URLNamedLocation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlink", 
		NodeName = "URLNamedLocation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the named location within a file that is referenced by a URL.", 
		ViewType = "Data")]
	[NodeInput("AcadHyperlink", typeof(object))]

	///<summary>
	///Specifies or returns the named location within a file that is referenced by a URL.
	///</summary>
	public class URLNamedLocation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.URLNamedLocation);

		}
	}
}
