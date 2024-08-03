using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a construction line that is infinite in both directions
///</summary>
namespace OdaX.AcadXline 
{

	[NVP_Manifest(
		Id = "A74A32E2-A939-4C90-A0B1-5604B587518A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXline.AcadXline_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXline", 
		NodeName = "_AcadXline_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadXline_Constructor : INode 
	{
		public OdaX.IAcadXline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadXline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D469EA92-54BE-42ED-A7FE-11BFB8E61027", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXline.AcadXline_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXline", 
		NodeName = "_AcadXline_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadXline_ConstructorCast : INode 
	{
		public OdaX.IAcadXline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadXline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "608F11BD-E13C-4C2E-A123-A4BF693E2631", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXline.BasePoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXline", 
		NodeName = "BasePoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specify the X, Y, Z coordinate for the base point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously", 
		ViewType = "Data")]
	[NodeInput("AcadXline", typeof(object))]

	///<summary>
	///Specify the X, Y, Z coordinate for the base point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously
	///</summary>
	public class BasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BasePoint);

		}
	}


	[NVP_Manifest(
		Id = "AA042FED-713C-4900-8627-4F195ECF80E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXline.Set_BasePoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXline", 
		NodeName = "Set_BasePoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specify the X, Y, Z coordinate for the base point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously", 
		ViewType = "Modifier")]
	[NodeInput("AcadXline", typeof(object))]
	[NodeInput("BasePoint", typeof(System.Object))]

	///<summary>
	///Specify the X, Y, Z coordinate for the base point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously
	///</summary>
	public class Set_BasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BasePoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D5860BCC-E5EE-4FE4-8B1D-39A9B0D63782", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXline.SecondPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXline", 
		NodeName = "SecondPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specify the X, Y, Z coordinate for the second point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously", 
		ViewType = "Data")]
	[NodeInput("AcadXline", typeof(object))]

	///<summary>
	///Specify the X, Y, Z coordinate for the second point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously
	///</summary>
	public class SecondPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SecondPoint);

		}
	}


	[NVP_Manifest(
		Id = "F03E4D29-AE02-4773-9CDA-A6B56BC8C76F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXline.Set_SecondPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXline", 
		NodeName = "Set_SecondPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specify the X, Y, Z coordinate for the second point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously", 
		ViewType = "Modifier")]
	[NodeInput("AcadXline", typeof(object))]
	[NodeInput("SecondPoint", typeof(System.Object))]

	///<summary>
	///Specify the X, Y, Z coordinate for the second point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously
	///</summary>
	public class Set_SecondPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SecondPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "086A5196-6435-41B5-839F-47E0CF78F071", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXline.DirectionVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXline", 
		NodeName = "DirectionVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specify the X, Y, Z coordinate for the direction vector of the Xline", 
		ViewType = "Data")]
	[NodeInput("AcadXline", typeof(object))]

	///<summary>
	///Specify the X, Y, Z coordinate for the direction vector of the Xline
	///</summary>
	public class DirectionVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DirectionVector);

		}
	}


	[NVP_Manifest(
		Id = "F5787F28-AC43-4AFD-AD0A-2646F1279D01", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXline.Set_DirectionVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXline", 
		NodeName = "Set_DirectionVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specify the X, Y, Z coordinate for the direction vector of the Xline", 
		ViewType = "Modifier")]
	[NodeInput("AcadXline", typeof(object))]
	[NodeInput("dirVector", typeof(System.Object))]

	///<summary>
	///Specify the X, Y, Z coordinate for the direction vector of the Xline
	///</summary>
	public class Set_DirectionVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DirectionVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8E9F7841-17DB-4E20-B31D-393E21910BD6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadXline.Offset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadXline", 
		NodeName = "Offset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a new entity object by offsetting the Xline by a specified distance", 
		ViewType = "Data")]
	[NodeInput("AcadXline", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Creates a new entity object by offsetting the Xline by a specified distance
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset(inputs[1].Value));

		}
	}
}
