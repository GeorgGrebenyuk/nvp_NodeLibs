using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.BeamStyle 
{

	[NVP_Manifest(
		Id = "6E1E545D-D287-4035-9B5D-33BC972FA1DD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamStyle.BeamStyle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamStyle", 
		NodeName = "_BeamStyle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BeamStyle_Constructor : INode 
	{
		public Renga.IBeamStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IBeamStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "66256C9B-DCE3-4584-8443-B1573C0AD215", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamStyle.BeamStyle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamStyle", 
		NodeName = "_BeamStyle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BeamStyle_ConstructorCast : INode 
	{
		public Renga.IBeamStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IBeamStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "47986818-2CDF-4104-A0E1-886F402CA76E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamStyle.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamStyle", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BeamStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		Id = "2E078333-35FB-4C95-B5F7-3894507264A8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamStyle.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamStyle", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BeamStyle", typeof(object))]

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
		Id = "9A5E7CD7-6C07-4E2D-B3B6-5D0EB9392686", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamStyle.Profile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamStyle", 
		NodeName = "Profile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BeamStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Profile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Profile);

		}
	}
}
