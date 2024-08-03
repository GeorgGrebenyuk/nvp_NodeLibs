using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///+); or as a combination of these
///</summary>
namespace OdaX.AcadPoint 
{

	[NVP_Manifest(
		Id = "F755D8AF-BD03-4085-AF01-2C76420E47D3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPoint.AcadPoint_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPoint", 
		NodeName = "_AcadPoint_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPoint_Constructor : INode 
	{
		public OdaX.IAcadPoint _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPoint;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F1458C09-CBED-4E6E-9B01-090CA1B6075A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPoint.AcadPoint_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPoint", 
		NodeName = "_AcadPoint_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPoint_ConstructorCast : INode 
	{
		public OdaX.IAcadPoint _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPoint;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "11840CB4-5F5B-456C-A920-F5CE3A68F6A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPoint.Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPoint", 
		NodeName = "Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current vertex of a point.", 
		ViewType = "Data")]
	[NodeInput("AcadPoint", typeof(object))]

	///<summary>
	///Specifies or returns the current vertex of a point.
	///</summary>
	public class Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinates);

		}
	}


	[NVP_Manifest(
		Id = "763F448E-9739-4685-BFA0-B42CCB244D62", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPoint.Set_Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPoint", 
		NodeName = "Set_Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current vertex of a point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPoint", typeof(object))]
	[NodeInput("Coordinates", typeof(System.Object))]

	///<summary>
	///Specifies or returns the current vertex of a point.
	///</summary>
	public class Set_Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinates = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E9464F7D-61A3-4822-B54C-18496B0ACCFD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPoint.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPoint", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadPoint", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	[NVP_Manifest(
		Id = "1C7521DD-FBBF-4226-A36D-02FF4EBCA6A2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPoint.Set_Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPoint", 
		NodeName = "Set_Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPoint", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6C4CA916-15E1-4D7F-8969-D54EB5765BC5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPoint.Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPoint", 
		NodeName = "Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z-direction value) of a point.", 
		ViewType = "Data")]
	[NodeInput("AcadPoint", typeof(object))]

	///<summary>
	///z-direction value) of a point.
	///</summary>
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	[NVP_Manifest(
		Id = "F94DAB4D-60F7-4B3D-A05A-CF4AACF2E995", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPoint.Set_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPoint", 
		NodeName = "Set_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z-direction value) of a point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPoint", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of a point.
	///</summary>
	public class Set_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Thickness = inputs[1].Value;
			return null;
		}
	}
}
