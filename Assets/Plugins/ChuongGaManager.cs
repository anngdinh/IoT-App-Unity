using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace M2MqttUnity.Examples
{
    public class ChuongGaManager : MonoBehaviour
    {

        [SerializeField]
        private Text temperature;
        [SerializeField]
        private Text humidity;


        public void Update_Status(Status_Data _status_data)
        {
            temperature.text = _status_data.temperature + " °C";
            humidity.text = _status_data.humidity + " %";

        }



    }
}