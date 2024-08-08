using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.AcadDwfUnderlay 
{

	[NVP_Manifest(
		Id = "1C297150-26E8-4D44-A1AA-51451C888FC2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDwfUnderlay.AcadDwfUnderlay_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDwfUnderlay", 
		NodeName = "_AcadDwfUnderlay_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDwfUnderlay_Constructor : INode 
	{
		public OdaX.IAcadDwfUnderlay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDwfUnderlay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "6C6DB3CD-D1C5-4A18-A38F-0DC467F0F449", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDwfUnderlay.AcadDwfUnderlay_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDwfUnderlay", 
		NodeName = "_AcadDwfUnderlay_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDwfUnderlay_ConstructorCast : INode 
	{
		public OdaX.IAcadDwfUnderlay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDwfUnderlay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "FBC0989D-CA95-4898-BA53-7BE39B1ABEA4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDwfUnderlay.DWFFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDwfUnderlay", 
		NodeName = "DWFFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the format of DWF file", 
		ViewType = "Data")]
	[NodeInput("AcadDwfUnderlay", typeof(object))]

	///<summary>
	///Specifies the format of DWF file
	///</summary>
	public class DWFFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DWFFormat);

		}
	}


	[NVP_Manifest(
		Id = "B3519D0B-A00C-4E7C-9D2F-43B9ED4C6E58", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDwfUnderlay.Set_DWFFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDwfUnderlay", 
		NodeName = "Set_DWFFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the format of DWF file", 
		ViewType = "Modifier")]
	[NodeInput("AcadDwfUnderlay", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies the format of DWF file
	///</summary>
	public class Set_DWFFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DWFFormat = inputs[1].Value;
			return null;
		}
	}
}
