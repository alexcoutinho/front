using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace VideoConverter
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true)
            {
                if (Request.Files["Upload"] != null)
                {

                    HttpPostedFile MyFile = Request.Files["Upload"];
                    //Setting location to upload files
                    string TargetLocation = Server.MapPath("~/Files/");
                    try
                    {
                        //if (MyFile.ContentLength > 0)
                        //{
                        //Determining file name. You can format it as you wish.
                        string FileName = MyFile.FileName;
                        //Determining file size.
                        int FileSize = MyFile.ContentLength;
                        //Creating a byte array corresponding to file size.
                        byte[] FileByteArray = new byte[FileSize];
                        //Posted file is being pushed into byte array.
                        MyFile.InputStream.Read(FileByteArray, 0, FileSize);
                        //Uploading properly formatted file to server.
                        //MyFile.SaveAs(TargetLocation + FileName);


                        var content = new MultipartFormDataContent();


                        content.Add(new StreamContent(MyFile.InputStream), "file", "filename");
                        //content.Add(new ObjectContent<TEnvio>(data, new JsonMediaTypeFormatter()), "model");


                        HttpClient client = new HttpClient();
                        client.BaseAddress = new Uri("http://localhost:8080");
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        //client.DefaultRequestHeaders.Add("videoParaConversao", Server.MapPath("~/uploads/" + MyFile));

                        HttpResponseMessage response = client.PostAsync("service/lerArquivo", content).Result;

                        if (response.IsSuccessStatusCode)
                        {
                            //pegando o cabeçalho
                            Uri usuarioUri = response.Headers.Location;

                            //Pegando os dados do Rest e armazenando na variável usuários
                            ; // var usuarios = response.Content.ReadAsAsync<IEnumerable<Usuario>>().Result;

                        }

                        else
                            Response.Write(response.StatusCode.ToString() + " - " + response.ReasonPhrase);
                        //}






                    }
                    catch (Exception BlueScreen)
                    {
                        //Handle errors
                    }

                }

            }
            //else
            //{
            //    // var = Path.Combine(Server.MapPath("~/App_Data"), Path.GetFileName(hpf.FileName))

            //    //context.Request.Files
            //    HttpFileCollection files = Request.Files;
            //    foreach (string key in files)
            //    {
            //        HttpPostedFile file = files[key];
            //        string fileName = file.FileName;

            //    }
            //}
        }




    }



}