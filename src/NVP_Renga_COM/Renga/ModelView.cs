using NVP.API.Nodes;

namespace Renga.ModelView 
{
		[NodeInput("dynamic", typeof(object))]
		public class ModelView_Constructor : INode 
		{
		public Renga.IModelView _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IModelView;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ModelView_ConstructorCast : INode 
		{
		public Renga.IModelView _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IModelView;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ModelView", typeof(object))]
		public class SetObjectsVisibility : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetObjectsVisibility();
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ModelView", typeof(object))]
		[NodeInput("objectId", typeof(System.Int32))]
		public class IsObjectVisible : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsObjectVisible(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ModelView", typeof(object))]
		public class SetObjectsVisualStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetObjectsVisualStyle();
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ModelView", typeof(object))]
		[NodeInput("objectId", typeof(System.Int32))]
		public class GetObjectVisualStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetObjectVisualStyle(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ModelView", typeof(object))]
		[NodeInput("pVisualStyle", typeof(System.Object))]
		public class Set_VisualStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.VisualStyle = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ModelView", typeof(object))]
		public class VisualStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.VisualStyle);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ModelView", typeof(object))]
		public class ShowObjects : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShowObjects();
				return null;
			}
		}
}
