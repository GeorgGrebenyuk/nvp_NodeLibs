using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IParameters Interface
///</summary>
namespace mdsLINEComLib.Parameters 
{

	[NVP_Manifest(
		Id = "EFBBB1EE-68F3-4111-A58E-E9D034431B99", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameters.Parameters_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameters", 
		NodeName = "_Parameters_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Parameters_Constructor : INode 
	{
		public mdsLINEComLib.IParameters _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IParameters;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "BF42E1A0-30D4-473D-8EE6-A14F7C8C958A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameters.Parameters_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameters", 
		NodeName = "_Parameters_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Parameters_ConstructorCast : INode 
	{
		public mdsLINEComLib.IParameters _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IParameters;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "37E99C09-05CF-4349-A9FC-A90AA6B6D6AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameters.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameters", 
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
		Id = "D30CB80A-6DD5-4B50-A64F-63A81E6DC9EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameters.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameters", 
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
		Id = "D68D93BC-0401-4A46-B1AA-A422CFC0AE14", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameters.SetParameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameters", 
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
		Id = "448334D8-6626-4304-ADEB-CB702AD38EA4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameters.DeleteParameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameters", 
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
		Id = "FD3B2FF5-51F9-4A87-A46D-DF3FF982D294", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameters.DeleteAll", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameters", 
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
		Id = "B96F8A52-CD23-4A07-92DE-216BEE540443", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Parameters.Has", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Parameters", 
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
