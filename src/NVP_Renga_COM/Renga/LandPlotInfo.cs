using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.LandPlotInfo 
{

	[NVP_Manifest(
		Id = "D5A4AAD5-C76B-48BD-AC49-3CAFAB6E56A9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LandPlotInfo.LandPlotInfo_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LandPlotInfo", 
		NodeName = "_LandPlotInfo_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LandPlotInfo_Constructor : INode 
	{
		public Renga.ILandPlotInfo _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILandPlotInfo;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "BEF89684-84CA-4A47-A1D3-B9F08222823E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LandPlotInfo.LandPlotInfo_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LandPlotInfo", 
		NodeName = "_LandPlotInfo_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LandPlotInfo_ConstructorCast : INode 
	{
		public Renga.ILandPlotInfo _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILandPlotInfo;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2EBBA17B-73B3-4B33-BF51-2A336096C86B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LandPlotInfo.Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LandPlotInfo", 
		NodeName = "Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LandPlotInfo", typeof(object))]

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
		Id = "3AB85467-0F7D-43ED-ACA5-5B976695D62A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LandPlotInfo.Set_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LandPlotInfo", 
		NodeName = "Set_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("LandPlotInfo", typeof(object))]
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
		Id = "61750B52-0FD2-449D-AAEE-B7DA7BB29C32", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LandPlotInfo.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LandPlotInfo", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LandPlotInfo", typeof(object))]

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
		Id = "398BEC0A-2FB7-44C5-9B87-AA885827B910", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LandPlotInfo.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LandPlotInfo", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("LandPlotInfo", typeof(object))]
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
		Id = "5D1C8B03-FF1D-43BB-BBB1-C9834A9F1AE5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LandPlotInfo.Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LandPlotInfo", 
		NodeName = "Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LandPlotInfo", typeof(object))]

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
		Id = "21B3331F-FEDD-4A13-B8EA-E3B8608F3D78", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LandPlotInfo.Set_Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LandPlotInfo", 
		NodeName = "Set_Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("LandPlotInfo", typeof(object))]
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
		Id = "8F15782B-70D8-45A4-8B43-9671240860E6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LandPlotInfo.GetAddress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LandPlotInfo", 
		NodeName = "GetAddress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LandPlotInfo", typeof(object))]

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
		Id = "512C86EA-9C52-4828-A84C-A35035D867AD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LandPlotInfo.GetProperties", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LandPlotInfo", 
		NodeName = "GetProperties", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LandPlotInfo", typeof(object))]

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
		Id = "F7B86ADB-059C-4294-BB1C-741E73538831", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LandPlotInfo.UniqueId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LandPlotInfo", 
		NodeName = "UniqueId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LandPlotInfo", typeof(object))]

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
		Id = "9FC86CAC-C8AF-4F65-8A95-B65D386D4E6C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LandPlotInfo.UniqueIdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LandPlotInfo", 
		NodeName = "UniqueIdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LandPlotInfo", typeof(object))]

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
