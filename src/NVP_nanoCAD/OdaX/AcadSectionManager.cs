using NVP.API.Nodes;

namespace OdaX.AcadSectionManager 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadSectionManager_Constructor : INode 
		{
		public OdaX.IAcadSectionManager _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadSectionManager;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadSectionManager_ConstructorCast : INode 
		{
		public OdaX.IAcadSectionManager _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadSectionManager;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns an object at a given index in the collection of sections.
		///</summary>
		[NodeInput("AcadSectionManager", typeof(object))]
		[NodeInput("Index", typeof(System.Object))]
		public class Item : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Item(inputs[1]));

			}
		}


		///<summary>
		///Returns the number of items in the collection of sections.
		///</summary>
		[NodeInput("AcadSectionManager", typeof(object))]
		public class Count : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Count);

			}
		}


		///<summary>
		///Returns the current live section.
		///</summary>
		[NodeInput("AcadSectionManager", typeof(object))]
		public class GetLiveSection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetLiveSection);

			}
		}


		///<summary>
		///Returns a unique section name.
		///</summary>
		[NodeInput("AcadSectionManager", typeof(object))]
		[NodeInput("pBaseName", typeof(System.String))]
		public class GetUniqueSectionName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetUniqueSectionName(inputs[1]));

			}
		}
}
