using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

public class Video
{
    public string apiURL { get; set; }
    public string videoURL { get; set; }
}
public class VideoModel
{
    public List<Video> videos { get; set; }

    public VideoModel()
    {


    }
    public void FillWithVideos()
    {
        Video video = new Video();
        videos = new List<Video>();
        video = new Video();
        video.apiURL = "http://swapi.dev/api/films/1/";
        video.videoURL = "KDFqhXHD3yk";
        videos.Add(video);
        video = new Video();
        video.apiURL = "http://swapi.dev/api/films/2/";
        video.videoURL = "kG58selILLs";
        videos.Add(video);
        video = new Video();
        video.apiURL = "http://swapi.dev/api/films/3/";
        video.videoURL = "7X1aNtTD3zA";
        videos.Add(video);
        video = new Video();
        video.apiURL = "http://swapi.dev/api/films/4/";
        video.videoURL = "LZtkDf8VRbw";
        videos.Add(video);
        video = new Video();
        video.apiURL = "http://swapi.dev/api/films/5/";
        video.videoURL = "ZXVG4LBo0wc";
        videos.Add(video);
        video = new Video();
        video.apiURL = "http://swapi.dev/api/films/6/";
        video.videoURL = "3eVDpFmc5DI";
        videos.Add(video);
        //"KDFqhXHD3yk";
    }
}

