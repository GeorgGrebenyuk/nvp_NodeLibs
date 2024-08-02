using NVP.API.Nodes;

namespace OdaX.AcadSectionTypeSettings2 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadSectionTypeSettings2_Constructor : INode 
		{
		public OdaX.IAcadSectionTypeSettings2 _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadSectionTypeSettings2;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadSectionTypeSettings2_ConstructorCast : INode 
		{
		public OdaX.IAcadSectionTypeSettings2 _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadSectionTypeSettings2;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies the visibility of intersection boundary
		///</summary>
		[NodeInput("AcadSectionTypeSettings2", typeof(object))]
		public class IntersectionBoundaryVisible : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IntersectionBoundaryVisible);

			}
		}


		///<summary>
		///Specifies the visibility of intersection boundary
		///</summary>
		[NodeInput("AcadSectionTypeSettings2", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_IntersectionBoundaryVisible : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.IntersectionBoundaryVisible = inputs[1];
				return null;
			}
		}
}
