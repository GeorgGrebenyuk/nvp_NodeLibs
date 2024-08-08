using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSCableJournal Interface
///</summary>
namespace mdsMetalLib.MDSCableJournal 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSCableJournal_Constructor : INode 
	{
		public mdsMetalLib.IMDSCableJournal _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsMetalLib.IMDSCableJournal;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSCableJournal_ConstructorCast : INode 
	{
		public mdsMetalLib.IMDSCableJournal _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsMetalLib.IMDSCableJournal;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MDSCableJournal", typeof(object))]

	///<summary>
	///Параметры
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Text = "Вычисление длины кабеля, проходящего по заданной конструкции", 
		ViewType = "Data")]
	[NodeInput("MDSCableJournal", typeof(object))]
	[NodeInput("ConstructionParam", typeof(System.String))]
	[NodeInput("ConstructionType", typeof(System.String))]

	///<summary>
	///Вычисление длины кабеля, проходящего по заданной конструкции
	///</summary>
	public class GetLengthByConstruction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLengthByConstruction(inputs[1].Value,inputs[2].Value));

		}
	}
}
