using NVP.API.Nodes;

namespace Renga.ExportedObject3D 
{
		[NodeInput("dynamic", typeof(object))]
		public class ExportedObject3D_Constructor : INode 
		{
		public Renga.IExportedObject3D _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IExportedObject3D;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ExportedObject3D_ConstructorCast : INode 
		{
		public Renga.IExportedObject3D _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IExportedObject3D;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ExportedObject3D", typeof(object))]
		public class ModelObjectId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ModelObjectId);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ExportedObject3D", typeof(object))]
		public class MeshCount : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MeshCount);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ExportedObject3D", typeof(object))]
		[NodeInput("index", typeof(System.Int32))]
		public class GetMesh : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetMesh(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ExportedObject3D", typeof(object))]
		public class ModelObjectType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ModelObjectType);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ExportedObject3D", typeof(object))]
		public class ModelObjectTypeS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ModelObjectTypeS);

			}
		}
}
