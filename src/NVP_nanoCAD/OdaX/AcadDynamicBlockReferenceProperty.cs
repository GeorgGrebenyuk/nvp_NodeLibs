using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an object containing the properties of a dynamic block
///</summary>
namespace OdaX.AcadDynamicBlockReferenceProperty 
{

	[NVP_Manifest(
		Id = "C6C66899-76C7-46B3-873D-635B63EECB16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDynamicBlockReferenceProperty.AcadDynamicBlockReferenceProperty_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDynamicBlockReferenceProperty", 
		NodeName = "_AcadDynamicBlockReferenceProperty_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDynamicBlockReferenceProperty_Constructor : INode 
	{
		public OdaX.IAcadDynamicBlockReferenceProperty _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDynamicBlockReferenceProperty;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B72C2B13-3E53-4811-99DC-68B41196CA78", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDynamicBlockReferenceProperty.AcadDynamicBlockReferenceProperty_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDynamicBlockReferenceProperty", 
		NodeName = "_AcadDynamicBlockReferenceProperty_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDynamicBlockReferenceProperty_ConstructorCast : INode 
	{
		public OdaX.IAcadDynamicBlockReferenceProperty _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDynamicBlockReferenceProperty;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "0D05053B-738A-4C88-AAFF-9F2A3980AFA5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDynamicBlockReferenceProperty.PropertyName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDynamicBlockReferenceProperty", 
		NodeName = "PropertyName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the name of the property.", 
		ViewType = "Data")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]

	///<summary>
	///Returns the name of the property.
	///</summary>
	public class PropertyName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PropertyName);

		}
	}


	[NVP_Manifest(
		Id = "C67346AA-B72B-47FA-B40D-5088A606E54C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDynamicBlockReferenceProperty.ReadOnly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDynamicBlockReferenceProperty", 
		NodeName = "ReadOnly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether a property is read-only.", 
		ViewType = "Data")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]

	///<summary>
	///Returns whether a property is read-only.
	///</summary>
	public class ReadOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReadOnly);

		}
	}


	[NVP_Manifest(
		Id = "1FD615FA-8824-4766-BFEA-BB6B342FA01D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDynamicBlockReferenceProperty.Show", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDynamicBlockReferenceProperty", 
		NodeName = "Show", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether a property is available in the application user interface.", 
		ViewType = "Data")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]

	///<summary>
	///Returns whether a property is available in the application user interface.
	///</summary>
	public class Show : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Show);

		}
	}


	[NVP_Manifest(
		Id = "8382671A-BABC-4A12-975D-DC5351AAD233", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDynamicBlockReferenceProperty.Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDynamicBlockReferenceProperty", 
		NodeName = "Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the description of the property.", 
		ViewType = "Data")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]

	///<summary>
	///Returns the description of the property.
	///</summary>
	public class Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Description);

		}
	}


	[NVP_Manifest(
		Id = "5E9DC112-93D9-4644-A027-E0CFF3D6BB10", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDynamicBlockReferenceProperty.AllowedValues", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDynamicBlockReferenceProperty", 
		NodeName = "AllowedValues", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the values that are valid for a property.", 
		ViewType = "Data")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]

	///<summary>
	///Returns the values that are valid for a property.
	///</summary>
	public class AllowedValues : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AllowedValues);

		}
	}


	[NVP_Manifest(
		Id = "6AA6F598-7EC2-4D44-B143-8F274BE7A30D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDynamicBlockReferenceProperty.Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDynamicBlockReferenceProperty", 
		NodeName = "Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the value of a property.", 
		ViewType = "Data")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]

	///<summary>
	///Specifies or returns the value of a property.
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
		Id = "BC681EF7-AD4F-4F26-ACCB-FC7E86140ACA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDynamicBlockReferenceProperty.Set_Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDynamicBlockReferenceProperty", 
		NodeName = "Set_Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the value of a property.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]
	[NodeInput("Value", typeof(System.Object))]

	///<summary>
	///Specifies or returns the value of a property.
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1CD84043-DCD4-4DFA-970E-5DF4842508B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDynamicBlockReferenceProperty.UnitsType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDynamicBlockReferenceProperty", 
		NodeName = "UnitsType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the current units type for the display of a property.", 
		ViewType = "Data")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]

	///<summary>
	///Returns the current units type for the display of a property.
	///</summary>
	public class UnitsType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitsType);

		}
	}
}
