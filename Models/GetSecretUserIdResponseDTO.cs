using System;

namespace NASATest2018.Models
{
    [Serializable]
    public class GetSecretUserIdResponseDTO: ResponseDTO
    {
        public string SecretUserId {get; set;}
    }
}