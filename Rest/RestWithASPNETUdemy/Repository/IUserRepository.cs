﻿using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Repository
{
    public interface IUserRepository
    {
        User ValideteCredentials(UserVO user);

        User RefreshUserInfo(User user);
    }
}
