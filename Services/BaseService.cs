using AdminService.DBContext;
using AdminService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AdminService.Services
{
    public abstract class BaseService
    {
        protected string _cacheKey = "";
        //protected IDistributedCache _distributedCache;
        protected IConfiguration _configuration;
        protected DbContextOptionsBuilder<pgzeusContext> _options;

        //protected BaseService(IDistributedCache distributedCache, IConfiguration configuration, string keyFormat)
        protected BaseService(IConfiguration configuration, string keyFormat, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _cacheKey = keyFormat;

            if (env.IsDevelopment())
            {
                _configuration = configuration;
                _cacheKey = keyFormat;
                _options = new DbContextOptionsBuilder<pgzeusContext>().UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
            }
            else
            {
                var conf = new ConfigurationBuilder()
                      .AddJsonFile("appsettings.json")
                      .AddJsonFile($"appsettings.{env.EnvironmentName}.json")
                      .AddEnvironmentVariables()
                      .Build();
                _options = new DbContextOptionsBuilder<pgzeusContext>().UseNpgsql(conf.GetConnectionString("DefaultConnection"));
            }
        }

        //protected async void SetCache(string key, byte[] data)
        //{
        //    try
        //    {
        //        DistributedCacheEntryOptions dcOptions = new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(60)).SetAbsoluteExpiration(DateTime.Now.AddHours(6));
        //        await _distributedCache.SetAsync(key, data, dcOptions);
        //    }
        //    catch (Exception ex) { }

        //}

        //protected async Task<byte[]> GetCache(string key)
        //{
        //    try
        //    {
        //        return await _distributedCache.GetAsync(key);
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}

        //protected async void RemoveCache(string key)
        //{
        //    try
        //    {
        //        if (await GetCache(key) != null)
        //        {
        //            await _distributedCache.RemoveAsync(key);
        //        }
        //    }
        //    catch (Exception ex) { }
        //}

        protected byte[] EncodeToByte<T>(T obj)
        {
            return System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(obj);

        }

        protected T DecodeToObject<T>(byte[] data)
        {
            return System.Text.Json.JsonSerializer.Deserialize<T>(Encoding.UTF8.GetString(data));
        }
    }
}
