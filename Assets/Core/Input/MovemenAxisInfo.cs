﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Core.Input
{
    public struct MovemenAxisInfo
	{
		public MoveDirection MovemoveDir;
		 

		public float horizontalValue { get; set; }
		public float verticalValue { get; set; }


	}
}
