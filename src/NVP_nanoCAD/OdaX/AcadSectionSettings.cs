using NVP.API.Nodes;

namespace OdaX.AcadSectionSettings 
{
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


	///<summary>
	///Specifies or returns the type for a section.
	///</summary>
	[NodeInput("AcadSectionSettings", typeof(object))]
	public class CurrentSectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurrentSectionType);

		}
	}


	///<summary>
	///Specifies or returns the type for a section.
	///</summary>
	[NodeInput("AcadSectionSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_CurrentSectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurrentSectionType = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the type for a Section Settings object.
	///</summary>
	[NodeInput("AcadSectionSettings", typeof(object))]
	[NodeInput("secType", typeof(System.Object))]
	public class GetSectionTypeSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetSectionTypeSettings(inputs[1]));

		}
	}
}
