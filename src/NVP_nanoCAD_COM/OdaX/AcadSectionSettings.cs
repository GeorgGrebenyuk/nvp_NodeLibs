using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a container for section geometry settings
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadSectionSettings 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionSettings_Constructor : INode 
	{
		public OdaX.IAcadSectionSettings _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSectionSettings;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionSettings_ConstructorCast : INode 
	{
		public OdaX.IAcadSectionSettings _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSectionSettings;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the type for a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionSettings", typeof(object))]

	///<summary>
	///Specifies or returns the type for a section.
	///</summary>
	public class CurrentSectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurrentSectionType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the type for a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionSettings", typeof(object))]
	[NodeInput("OdaX.AcSectionType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type for a section.
	///</summary>
	public class Set_CurrentSectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurrentSectionType = ((OdaX.AcSectionType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the type for a Section Settings object.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionSettings", typeof(object))]
	[NodeInput("OdaX.AcSectionType", typeof(System.Object))]

	///<summary>
	///Returns the type for a Section Settings object.
	///</summary>
	public class GetSectionTypeSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetSectionTypeSettings(((OdaX.AcSectionType)inputs[1].Value)));

		}
	}
}
