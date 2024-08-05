using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IParameters Interface
///</summary>
namespace mdsUnitsLib.Parameters 
{

	[NVP_Manifest(
		Id = "34BB3D43-D1FE-4908-867F-D82231E84105", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameters.Parameters_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameters", 
		NodeName = "_Parameters_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Parameters_Constructor : INode 
	{
		public mdsUnitsLib.IParameters _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IParameters;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A208A649-B6B1-46D1-9088-FB74D0C7F99F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameters.Parameters_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameters", 
		NodeName = "_Parameters_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Parameters_ConstructorCast : INode 
	{
		public mdsUnitsLib.IParameters _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IParameters;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2B2E9CCB-F4E5-498B-AEDB-8582039AE578", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameters.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameters", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Item", 
		ViewType = "Data")]
	[NodeInput("Parameters", typeof(object))]

	///<summary>
	///method Item
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item);

		}
	}


	[NVP_Manifest(
		Id = "A0A583E7-55B7-414A-84C2-D69953628690", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameters.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameters", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Count", 
		ViewType = "Data")]
	[NodeInput("Parameters", typeof(object))]

	///<summary>
	///property Count
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Id = "76CEF037-BD1B-4AB7-B0C1-1EC54C36B36E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameters.SetParameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameters", 
		NodeName = "SetParameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method SetParameter", 
		ViewType = "Modifier")]
	[NodeInput("Parameters", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Value", typeof(System.String))]
	[NodeInput("Comment", typeof(System.Object))]
	[NodeInput("ValueComment", typeof(System.Object))]

	///<summary>
	///method SetParameter
	///</summary>
	public class SetParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetParameter(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1C979C7E-4794-4273-A548-5832D6527CD1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameters.DeleteParameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameters", 
		NodeName = "DeleteParameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method DeleteParameter", 
		ViewType = "Modifier")]
	[NodeInput("Parameters", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///method DeleteParameter
	///</summary>
	public class DeleteParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteParameter(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CF94DCA5-1F08-4A0A-B7B4-DA14F836DF3D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameters.DeleteAll", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameters", 
		NodeName = "DeleteAll", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method DeleteAll", 
		ViewType = "Modifier")]
	[NodeInput("Parameters", typeof(object))]

	///<summary>
	///method DeleteAll
	///</summary>
	public class DeleteAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteAll();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DEE29DCF-39CB-4214-ADD3-B2128C8AFD80", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Parameters.Has", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Parameters", 
		NodeName = "Has", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Has", 
		ViewType = "Data")]
	[NodeInput("Parameters", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///method Has
	///</summary>
	public class Has : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Has(inputs[1].Value));

		}
	}
}
