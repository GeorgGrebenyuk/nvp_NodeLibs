using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSSectionDef Interface
///</summary>
namespace mdsMetalLib.MDSSectionDef 
{

	[NVP_Manifest(
		Id = "9654019B-10CC-4640-93C6-69203A2E4810", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSSectionDef.MDSSectionDef_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSSectionDef", 
		NodeName = "_MDSSectionDef_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSSectionDef_Constructor : INode 
	{
		public mdsMetalLib.IMDSSectionDef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsMetalLib.IMDSSectionDef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D1F50B1A-4E5A-4B9E-9D70-D411C391C8FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSSectionDef.MDSSectionDef_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSSectionDef", 
		NodeName = "_MDSSectionDef_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSSectionDef_ConstructorCast : INode 
	{
		public mdsMetalLib.IMDSSectionDef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsMetalLib.IMDSSectionDef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "21FA3D1F-C7D3-424B-A75A-E983BBFD1563", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSSectionDef.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSSectionDef", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Name", 
		ViewType = "Data")]
	[NodeInput("MDSSectionDef", typeof(object))]

	///<summary>
	///property Name
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "922E0B8E-C965-4B59-A7DF-7D4867CE4B64", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSSectionDef.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSSectionDef", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Name", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionDef", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Name
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8783C5A2-2BF1-4A24-8D73-BDB1B6D24EF7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSSectionDef.TextStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSSectionDef", 
		NodeName = "TextStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property TextStyleName", 
		ViewType = "Data")]
	[NodeInput("MDSSectionDef", typeof(object))]

	///<summary>
	///property TextStyleName
	///</summary>
	public class TextStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyleName);

		}
	}


	[NVP_Manifest(
		Id = "8C3DED86-95ED-4A41-8106-797265F4B32F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSSectionDef.Set_TextStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSSectionDef", 
		NodeName = "Set_TextStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property TextStyleName", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionDef", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property TextStyleName
	///</summary>
	public class Set_TextStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ADBE2F51-603F-4E67-A3CD-61526B385D5E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSSectionDef.TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSSectionDef", 
		NodeName = "TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property TextHeight", 
		ViewType = "Data")]
	[NodeInput("MDSSectionDef", typeof(object))]

	///<summary>
	///property TextHeight
	///</summary>
	public class TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextHeight);

		}
	}


	[NVP_Manifest(
		Id = "EE1DD427-ABC4-4D0A-829E-ABA8C85F4FD8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSSectionDef.Set_TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSSectionDef", 
		NodeName = "Set_TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property TextHeight", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property TextHeight
	///</summary>
	public class Set_TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CD55DE92-A534-4D23-815E-3CDEDC521F55", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSSectionDef.StrokeLng", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSSectionDef", 
		NodeName = "StrokeLng", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property StrokeLng", 
		ViewType = "Data")]
	[NodeInput("MDSSectionDef", typeof(object))]

	///<summary>
	///property StrokeLng
	///</summary>
	public class StrokeLng : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StrokeLng);

		}
	}


	[NVP_Manifest(
		Id = "C370D85F-00FB-4B08-BFCE-8F0874F5A32C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSSectionDef.Set_StrokeLng", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSSectionDef", 
		NodeName = "Set_StrokeLng", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property StrokeLng", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property StrokeLng
	///</summary>
	public class Set_StrokeLng : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StrokeLng = inputs[1].Value;
			return null;
		}
	}
}
