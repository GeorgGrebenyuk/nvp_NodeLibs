using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of the render material characteristics
///</summary>
namespace OdaX.AcadMaterial 
{

	[NVP_Manifest(
		Id = "C8F200CE-62F8-4032-8085-23044F916E7E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMaterial.AcadMaterial_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMaterial", 
		NodeName = "_AcadMaterial_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMaterial_Constructor : INode 
	{
		public OdaX.IAcadMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "66CCD36B-8F1F-4435-8291-50D97C23133A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMaterial.AcadMaterial_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMaterial", 
		NodeName = "_AcadMaterial_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMaterial_ConstructorCast : INode 
	{
		public OdaX.IAcadMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "34818661-E7DF-44E0-98B1-082580705060", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMaterial.Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMaterial", 
		NodeName = "Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the description of a material.", 
		ViewType = "Data")]
	[NodeInput("AcadMaterial", typeof(object))]

	///<summary>
	///Specifies or returns the description of a material.
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
		Id = "C1DCF324-84CD-44EB-9574-D8C378335188", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMaterial.Set_Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMaterial", 
		NodeName = "Set_Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the description of a material.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMaterial", typeof(object))]
	[NodeInput("bstrDes", typeof(System.String))]

	///<summary>
	///Specifies or returns the description of a material.
	///</summary>
	public class Set_Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Description = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DE5414FB-21EA-450F-8CDD-668133A12E9D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMaterial.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMaterial", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of a material.", 
		ViewType = "Data")]
	[NodeInput("AcadMaterial", typeof(object))]

	///<summary>
	///Specifies or returns the name of a material.
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
		Id = "62D8ABDF-8487-41AB-A0DB-DFC6A5AFA6D8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMaterial.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMaterial", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of a material.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMaterial", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of a material.
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
}
