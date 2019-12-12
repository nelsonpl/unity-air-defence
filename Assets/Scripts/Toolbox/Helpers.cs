using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Entities;
using UnityEngine;

namespace Assets.Scripts.Toolbox
{
    internal static class Helpers
    {
        internal static void ToFly(this GameObject go, EPosition ePosition, EVelocity eVelocity)
        {
            var shapeRb = go.GetComponent<Rigidbody2D>();
            shapeRb.velocity = Utils.GetVelocity(ePosition, eVelocity);
            go.transform.position = Utils.GetPosition(ePosition);
            go.transform.Rotate(Utils.GetRotate(ePosition));
        }
    }
}
