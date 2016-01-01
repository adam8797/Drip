using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illinois.SeaPerch.Net
{
  /// <summary>
  /// These are the commands that can be sent to the rover.
  /// </summary>
  public enum CommandField
  {
    // Command Field 0  = reserved (send 0)

    /// <summary>
    /// Command Field 1  = Propeller A - mode  [0 1 2 3]
    /// </summary>
    PropellerA_mode  = 1,
    
    /// <summary>
    /// Command Field 2  = Propeller A - speed [0...100]
    /// </summary>
    PropellerA_speed = 2  ,
    
    /// <summary>
    /// Command Field 3  = Propeller B - mode  [0 1 2 3]
    /// </summary>
    PropellerB_mode = 3  ,
    
    /// <summary>
    /// Command Field 4  = Propeller B - speed [0...100]
    /// </summary>
    PropellerB_speed = 4  ,

    /// <summary>
    /// Command Field 5  = Propeller C - mode  [0 1 2 3]
    /// </summary>
    PropellerC_mode = 5  ,

    /// <summary>
    /// Command Field 6  = Propeller C - speed [0...100]
    /// </summary>
    PropellerC_speed = 6  ,

    /// <summary>
    /// Command Field 7  = Light 1 (ON) - 0 (OFF)  
    /// </summary>
    Light = 7,
    
    /// <summary>
    /// Command Field 8  = AUX1  1(ON) - 0 (OFF)
    /// </summary>
    AUX1 = 8,

    /// <summary>
    /// Command Field 9  = AUX2  1(ON) - 0 (OFF)
    /// </summary>
    AUX2 = 9,

    // Command Field 10 = reserved (send 0)  
    // Command Field 11 = reserved (send 0)
    // Command Field 12 = reserved (send 0)
    // Command Field 13 = reserved (send 0)
    // Command Field 14 = reserved (send 0)
    // Command Field 15 = reserved (send 0)
    // Command Field 16 = reserved (send 0)  
    // Command Field 17 = reserved (send 0)

    /// <summary>
    /// Command Field 18 = 100
    /// </summary>
    HoldDepth = 18,

    /// <summary>
    /// Command Field 19 = 1/0
    /// </summary>
    HoldDepthFlag = 19,

    /// <summary>
    /// Command Field 20 = HOLD POSITION  1(ON) - 0 (OFF)
    /// </summary>
    HoldPosition = 20,
  }
}
