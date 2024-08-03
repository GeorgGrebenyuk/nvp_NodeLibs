using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///The standard interface for a basic TeighaX object
///</summary>
namespace OdaX.AcadObject 
{

	[NVP_Manifest(
		Id = "CC903B08-C953-470B-A019-E27B91A2CC83", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.AcadObject_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "_AcadObject_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadObject_Constructor : INode 
	{
		public OdaX.IAcadObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C61830C8-0472-4A07-A4DF-CE5D409613C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.AcadObject_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "_AcadObject_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadObject_ConstructorCast : INode 
	{
		public OdaX.IAcadObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "522CBB3C-B824-44C5-B1CE-47BEE0F4D55A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.Handle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "Handle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the handle of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns the handle of an object.
	///</summary>
	public class Handle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Handle);

		}
	}


	[NVP_Manifest(
		Id = "65F818AF-A1DA-4CF1-B30B-4056363CEB59", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.ObjectName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "ObjectName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the TeighaX class name of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns the TeighaX class name of an object.
	///</summary>
	public class ObjectName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectName);

		}
	}


	[NVP_Manifest(
		Id = "1C96EF8A-0672-491D-8FB3-1E30BCE35DDC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.GetXData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "GetXData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "XData) associated with an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadObject", typeof(object))]
	[NodeInput("AppName", typeof(System.String))]
	[NodeInput("XDataType", typeof(System.Object))]
	[NodeInput("XDataValue", typeof(System.Object))]

	///<summary>
	///XData) associated with an object.
	///</summary>
	public class GetXData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetXData(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E94FB368-2D0D-4C77-8AE0-3B1B5AD4FC90", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.SetXData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "SetXData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "XData) associated with an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadObject", typeof(object))]
	[NodeInput("XDataType", typeof(System.Object))]
	[NodeInput("XDataValue", typeof(System.Object))]

	///<summary>
	///XData) associated with an object.
	///</summary>
	public class SetXData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetXData(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A6CC03EF-1CBB-4469-9C0C-0E4B782E8ABF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.Delete", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "Delete", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes a specified object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadObject", typeof(object))]

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
		Id = "438D16AD-21F6-4986-BA81-F3D9C9F915C8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.ObjectID", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "ObjectID", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the object ID of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns the object ID of an object.
	///</summary>
	public class ObjectID : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectID);

		}
	}


	[NVP_Manifest(
		Id = "0686D3D9-988A-4359-8715-723C5F2268B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

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
		Id = "DC3976D9-93D6-4E34-924D-3AB1081E98B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.Database", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "Database", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the database in which the object belongs.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns the database in which the object belongs.
	///</summary>
	public class Database : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Database);

		}
	}


	[NVP_Manifest(
		Id = "0268DDF6-240B-43C3-8DF1-C4DE357324A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.HasExtensionDictionary", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "HasExtensionDictionary", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether an object has an associated extension dictionary.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns whether an object has an associated extension dictionary.
	///</summary>
	public class HasExtensionDictionary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasExtensionDictionary);

		}
	}


	[NVP_Manifest(
		Id = "6049BC12-FFE3-4FD9-BB6D-BF860F37E3F0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.GetExtensionDictionary", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "GetExtensionDictionary", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the extension dictionary associated with an object.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns the extension dictionary associated with an object.
	///</summary>
	public class GetExtensionDictionary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetExtensionDictionary);

		}
	}


	[NVP_Manifest(
		Id = "438930AA-2E67-4173-BF10-B77B2B2C40F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.OwnerID", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "OwnerID", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the object ID of the parent object.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns the object ID of the parent object.
	///</summary>
	public class OwnerID : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OwnerID);

		}
	}


	[NVP_Manifest(
		Id = "ABE9107D-6C48-47F8-9D6E-4F78AF922002", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.Document", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "Document", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the drawing to which an object belongs.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns the drawing to which an object belongs.
	///</summary>
	public class Document : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Document);

		}
	}


	[NVP_Manifest(
		Id = "13D6EF51-7649-427B-A3FB-18F544E8058B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadObject.HiddenField_Erase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadObject", 
		NodeName = "HiddenField_Erase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Erases all the objects in a selection set", 
		ViewType = "Modifier")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Erases all the objects in a selection set
	///</summary>
	public class HiddenField_Erase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return null;
		}
	}
}
