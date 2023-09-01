using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

        private bool m_IsOnGround;

        public bool IsOnGround
        {
            get
            {
                if (m_IsOnGround)
                {
                    m_IsOnGround = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        void OnCollisionStay()
        {
            //If it touch things, then it's on ground, that's my rule
            m_IsOnGround = true;
        }
    
}
