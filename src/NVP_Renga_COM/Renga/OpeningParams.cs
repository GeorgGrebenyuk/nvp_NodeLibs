using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.OpeningParams 
{

	[NVP_Manifest(
		Id = "7F56B2AA-5DBE-4C00-9BE6-BBE61C4D730F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.OpeningParams.OpeningParams_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.OpeningParams", 
		NodeName = "_OpeningParams_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OpeningParams_Constructor : INode 
	{
		public Renga.IOpeningParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IOpeningParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "12F89AF4-F0C5-4D54-88BE-F5F1AC6355DC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.OpeningParams.OpeningParams_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.OpeningParams", 
		NodeName = "_OpeningParams_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OpeningParams_ConstructorCast : INode 
	{
		public Renga.IOpeningParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IOpeningParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "DD7195B9-647F-4741-86DF-B8E0D5DF0539", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.OpeningParams.GetContour", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.OpeningParams", 
		NodeName = "GetContour", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OpeningParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetContour : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContour);

		}
	}


	[NVP_Manifest(
		Id = "ED59C1ED-EC96-4BB0-81DA-33B26AE889B8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.OpeningParams.Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.OpeningParams", 
		NodeName = "Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OpeningParams", typeof(object))]

	///<summary>
	///
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
		Id = "DE9AD99B-47C3-4191-92F2-2A04430624A1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.OpeningParams.VerticalOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.OpeningParams", 
		NodeName = "VerticalOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OpeningParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class VerticalOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalOffset);

		}
	}


	[NVP_Manifest(
		Id = "549E7A8B-26C1-46D3-97B6-C8BCC45BC542", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.OpeningParams.GetAffectedObjectIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.OpeningParams", 
		NodeName = "GetAffectedObjectIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OpeningParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetAffectedObjectIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetAffectedObjectIds();
			return null;
		}
	}
}
