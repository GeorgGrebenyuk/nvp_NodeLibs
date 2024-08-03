using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a user-defined coordinate system that determines the orientation of the X, Y, and Z axes in 3D space
///</summary>
namespace OdaX.AcadUCS 
{

	[NVP_Manifest(
		Id = "847F920A-99C7-465F-A075-68CD507DE6DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUCS.AcadUCS_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUCS", 
		NodeName = "_AcadUCS_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadUCS_Constructor : INode 
	{
		public OdaX.IAcadUCS _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadUCS;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "2FC88DED-822D-4CDB-AE02-A0961C6843A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUCS.AcadUCS_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUCS", 
		NodeName = "_AcadUCS_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadUCS_ConstructorCast : INode 
	{
		public OdaX.IAcadUCS _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadUCS;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "BDB1E6EB-9871-4A92-B988-A8DB4BD8EE24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUCS.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUCS", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("AcadUCS", typeof(object))]

	///<summary>
	///Specifies the name of the object
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
		Id = "47B8492A-F928-4464-9D34-28D5169D34E2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUCS.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUCS", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Modifier")]
	[NodeInput("AcadUCS", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the name of the object
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
		Id = "30314541-6A41-43B6-8AB7-DF440EB4E5B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUCS.Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUCS", 
		NodeName = "Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the origin of the UCS, block, layout, or raster image in WCS coordinates", 
		ViewType = "Data")]
	[NodeInput("AcadUCS", typeof(object))]

	///<summary>
	///Specifies the origin of the UCS, block, layout, or raster image in WCS coordinates
	///</summary>
	public class Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Origin);

		}
	}


	[NVP_Manifest(
		Id = "81B033F4-5FAD-4D69-9E63-C94E4EF1C568", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUCS.Set_Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUCS", 
		NodeName = "Set_Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the origin of the UCS, block, layout, or raster image in WCS coordinates", 
		ViewType = "Modifier")]
	[NodeInput("AcadUCS", typeof(object))]
	[NodeInput("Origin", typeof(System.Object))]

	///<summary>
	///Specifies the origin of the UCS, block, layout, or raster image in WCS coordinates
	///</summary>
	public class Set_Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Origin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B3F61F8F-C449-4D6D-8D80-827A4E492B01", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUCS.XVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUCS", 
		NodeName = "XVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the X direction of the given UCS", 
		ViewType = "Data")]
	[NodeInput("AcadUCS", typeof(object))]

	///<summary>
	///Specifies the X direction of the given UCS
	///</summary>
	public class XVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XVector);

		}
	}


	[NVP_Manifest(
		Id = "8113F563-8CF4-4292-8AC1-B6A8D2958405", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUCS.Set_XVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUCS", 
		NodeName = "Set_XVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the X direction of the given UCS", 
		ViewType = "Modifier")]
	[NodeInput("AcadUCS", typeof(object))]
	[NodeInput("XVector", typeof(System.Object))]

	///<summary>
	///Specifies the X direction of the given UCS
	///</summary>
	public class Set_XVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0C987C0C-6289-47D6-8ED4-0187A17245F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUCS.YVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUCS", 
		NodeName = "YVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the Y direction of the given UCS", 
		ViewType = "Data")]
	[NodeInput("AcadUCS", typeof(object))]

	///<summary>
	///Specifies the Y direction of the given UCS
	///</summary>
	public class YVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.YVector);

		}
	}


	[NVP_Manifest(
		Id = "34D4B449-E242-4A9D-BD28-5B68E37C4420", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUCS.Set_YVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUCS", 
		NodeName = "Set_YVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the Y direction of the given UCS", 
		ViewType = "Modifier")]
	[NodeInput("AcadUCS", typeof(object))]
	[NodeInput("YVector", typeof(System.Object))]

	///<summary>
	///Specifies the Y direction of the given UCS
	///</summary>
	public class Set_YVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.YVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3B1DBCBC-191E-4783-B9A4-521D7F9527F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUCS.GetUCSMatrix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUCS", 
		NodeName = "GetUCSMatrix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the transformation matrix consisting of UCS coordinate system data", 
		ViewType = "Data")]
	[NodeInput("AcadUCS", typeof(object))]

	///<summary>
	///Gets the transformation matrix consisting of UCS coordinate system data
	///</summary>
	public class GetUCSMatrix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetUCSMatrix);

		}
	}
}
