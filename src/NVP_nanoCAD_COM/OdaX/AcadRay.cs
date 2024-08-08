using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a semi-infinite line entity
///</summary>
namespace OdaX.AcadRay 
{

	[NVP_Manifest(
		Id = "753D137D-6EDF-4563-AA86-0F3DB9CE8931", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRay.AcadRay_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRay", 
		NodeName = "_AcadRay_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadRay_Constructor : INode 
	{
		public OdaX.IAcadRay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadRay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A1DEB6AB-D3F2-44C4-9B4F-56A29F2B065F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRay.AcadRay_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRay", 
		NodeName = "_AcadRay_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadRay_ConstructorCast : INode 
	{
		public OdaX.IAcadRay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadRay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "89DED3A3-514B-4737-B202-D3F7B0592A72", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRay.BasePoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRay", 
		NodeName = "BasePoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of a ray.", 
		ViewType = "Data")]
	[NodeInput("AcadRay", typeof(object))]

	///<summary>
	///Specifies or returns the start point of a ray.
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
		Id = "92078863-7FCF-4392-888E-B478C62CEAD2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRay.Set_BasePoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRay", 
		NodeName = "Set_BasePoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of a ray.", 
		ViewType = "Modifier")]
	[NodeInput("AcadRay", typeof(object))]
	[NodeInput("BasePoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the start point of a ray.
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
		Id = "1A22D0D0-4F60-45D2-82D7-DF61DD71ACBE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRay.SecondPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRay", 
		NodeName = "SecondPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the second point of a ray.", 
		ViewType = "Data")]
	[NodeInput("AcadRay", typeof(object))]

	///<summary>
	///Specifies or returns the second point of a ray.
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
		Id = "74F2958E-ED49-4686-BD82-D169990BED12", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRay.Set_SecondPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRay", 
		NodeName = "Set_SecondPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the second point of a ray.", 
		ViewType = "Modifier")]
	[NodeInput("AcadRay", typeof(object))]
	[NodeInput("SecondPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the second point of a ray.
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
		Id = "7C62F09C-2008-400B-93A2-B39C413521A9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRay.DirectionVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRay", 
		NodeName = "DirectionVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the direction vector of a ray.", 
		ViewType = "Data")]
	[NodeInput("AcadRay", typeof(object))]

	///<summary>
	///Specifies or returns the direction vector of a ray.
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
		Id = "A5C9C0E5-9BAD-4F9E-BBA6-E34735854B36", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRay.Set_DirectionVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRay", 
		NodeName = "Set_DirectionVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the direction vector of a ray.", 
		ViewType = "Modifier")]
	[NodeInput("AcadRay", typeof(object))]
	[NodeInput("dirVector", typeof(System.Object))]

	///<summary>
	///Specifies or returns the direction vector of a ray.
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
}
