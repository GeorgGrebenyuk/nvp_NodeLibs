using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.BuildingInfo 
{

	[NVP_Manifest(
		Id = "E9B7B81E-6888-4181-A309-14BC6DF7F005", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BuildingInfo.BuildingInfo_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BuildingInfo", 
		NodeName = "_BuildingInfo_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BuildingInfo_Constructor : INode 
	{
		public Renga.IBuildingInfo _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IBuildingInfo;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A1A17B95-5D25-405B-A476-5485141D8AFE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BuildingInfo.BuildingInfo_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BuildingInfo", 
		NodeName = "_BuildingInfo_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BuildingInfo_ConstructorCast : INode 
	{
		public Renga.IBuildingInfo _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IBuildingInfo;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "644F48BE-0E37-41D4-B073-0A0864F5C4A9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BuildingInfo.Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BuildingInfo", 
		NodeName = "Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BuildingInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Number);

		}
	}


	[NVP_Manifest(
		Id = "0EF9C8C4-BC1F-480B-8B62-B34D1696B02E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BuildingInfo.Set_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BuildingInfo", 
		NodeName = "Set_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("BuildingInfo", typeof(object))]
	[NodeInput("pNumber", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Number = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F678FB6F-6C9A-4865-955A-04D1C04BCD2C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BuildingInfo.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BuildingInfo", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BuildingInfo", typeof(object))]

	///<summary>
	///
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
		Id = "A22E6267-5FA3-460A-AFEB-01FF0467A466", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BuildingInfo.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BuildingInfo", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("BuildingInfo", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///
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
		Id = "5F853221-F795-4BC8-9785-3D0C0761632E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BuildingInfo.Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BuildingInfo", 
		NodeName = "Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BuildingInfo", typeof(object))]

	///<summary>
	///
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
		Id = "3129BA23-4D58-4C5F-B7C6-9528B15ED1CA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BuildingInfo.Set_Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BuildingInfo", 
		NodeName = "Set_Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("BuildingInfo", typeof(object))]
	[NodeInput("pDescription", typeof(System.String))]

	///<summary>
	///
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
		Id = "EADB4925-2E2F-4AFC-9259-2053D3EB13AB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BuildingInfo.GetAddress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BuildingInfo", 
		NodeName = "GetAddress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BuildingInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetAddress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAddress);

		}
	}


	[NVP_Manifest(
		Id = "2BB1857A-A752-403A-9DF8-846EC62F74FB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BuildingInfo.GetProperties", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BuildingInfo", 
		NodeName = "GetProperties", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BuildingInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetProperties : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetProperties);

		}
	}


	[NVP_Manifest(
		Id = "2030C3FD-4D2A-4236-9C15-630EBEAD4391", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BuildingInfo.UniqueId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BuildingInfo", 
		NodeName = "UniqueId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BuildingInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class UniqueId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UniqueId);

		}
	}


	[NVP_Manifest(
		Id = "D7DA239E-E43A-41C6-98E2-0284AA80B9FA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BuildingInfo.UniqueIdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BuildingInfo", 
		NodeName = "UniqueIdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BuildingInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class UniqueIdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UniqueIdS);

		}
	}
}
