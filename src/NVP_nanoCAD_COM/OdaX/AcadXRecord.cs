using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of XRecord objects are used to store and manage arbitrary data
///</summary>
namespace OdaX.AcadXRecord 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadXRecord_Constructor : INode 
	{
		public OdaX.IAcadXRecord _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadXRecord;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadXRecord_ConstructorCast : INode 
	{
		public OdaX.IAcadXRecord _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadXRecord;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("AcadXRecord", typeof(object))]

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
		Text = "Specifies the name of the object", 
		ViewType = "Modifier")]
	[NodeInput("AcadXRecord", typeof(object))]
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
		Text = "XRecordData) associated with a dictionary", 
		ViewType = "Modifier")]
	[NodeInput("AcadXRecord", typeof(object))]
	[NodeInput("XRecordDataType", typeof(System.Object))]
	[NodeInput("XRecordDataValue", typeof(System.Object))]

	///<summary>
	///XRecordData) associated with a dictionary
	///</summary>
	public class GetXRecordData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetXRecordData(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "XRecordData) associated with a dictionary", 
		ViewType = "Modifier")]
	[NodeInput("AcadXRecord", typeof(object))]
	[NodeInput("XRecordDataType", typeof(System.Object))]
	[NodeInput("XRecordDataValue", typeof(System.Object))]

	///<summary>
	///XRecordData) associated with a dictionary
	///</summary>
	public class SetXRecordData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetXRecordData(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the translation of any contained object IDs during deepClone or wblockClone operations", 
		ViewType = "Data")]
	[NodeInput("AcadXRecord", typeof(object))]

	///<summary>
	///Specifies the translation of any contained object IDs during deepClone or wblockClone operations
	///</summary>
	public class TranslateIDs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TranslateIDs);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the translation of any contained object IDs during deepClone or wblockClone operations", 
		ViewType = "Modifier")]
	[NodeInput("AcadXRecord", typeof(object))]
	[NodeInput("xlateIds", typeof(System.Object))]

	///<summary>
	///Specifies the translation of any contained object IDs during deepClone or wblockClone operations
	///</summary>
	public class Set_TranslateIDs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TranslateIDs = inputs[1].Value;
			return null;
		}
	}
}
