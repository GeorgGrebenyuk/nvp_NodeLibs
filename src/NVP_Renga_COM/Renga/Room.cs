using NVP.API.Nodes;

namespace Renga.Room 
{
		[NodeInput("dynamic", typeof(object))]
		public class Room_Constructor : INode 
		{
		public Renga.IRoom _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IRoom;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Room_ConstructorCast : INode 
		{
		public Renga.IRoom _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IRoom;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Room", typeof(object))]
		public class RoomName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.RoomName);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Room", typeof(object))]
		public class RoomNumber : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.RoomNumber);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Room", typeof(object))]
		public class MarkerPosition : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MarkerPosition);

			}
		}
}
