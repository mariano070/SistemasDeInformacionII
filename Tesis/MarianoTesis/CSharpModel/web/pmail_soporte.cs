/*
               File: PMAIL_SOPORTE
        Description: MAIL_ SOPORTE
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/29/2014 16:46:50.20
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Mail;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class pmail_soporte : GXProcedure
   {
      public pmail_soporte( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pmail_soporte( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ASUNTO ,
                           ref String aP1_MENSAJE )
      {
         this.AV11ASUNTO = aP0_ASUNTO;
         this.AV12MENSAJE = aP1_MENSAJE;
         initialize();
         executePrivate();
         aP0_ASUNTO=this.AV11ASUNTO;
         aP1_MENSAJE=this.AV12MENSAJE;
      }

      public String executeUdp( ref String aP0_ASUNTO )
      {
         this.AV11ASUNTO = aP0_ASUNTO;
         this.AV12MENSAJE = aP1_MENSAJE;
         initialize();
         executePrivate();
         aP0_ASUNTO=this.AV11ASUNTO;
         aP1_MENSAJE=this.AV12MENSAJE;
         return AV12MENSAJE ;
      }

      public void executeSubmit( ref String aP0_ASUNTO ,
                                 ref String aP1_MENSAJE )
      {
         pmail_soporte objpmail_soporte;
         objpmail_soporte = new pmail_soporte();
         objpmail_soporte.AV11ASUNTO = aP0_ASUNTO;
         objpmail_soporte.AV12MENSAJE = aP1_MENSAJE;
         objpmail_soporte.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpmail_soporte.executePrivateCatch ));
         aP0_ASUNTO=this.AV11ASUNTO;
         aP1_MENSAJE=this.AV12MENSAJE;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV10EVENTOch = StringUtil.Str( (decimal)(50), 15, 0) ;
         AV10EVENTOch = StringUtil.PadL( AV10EVENTOch, 15, "0") ;
         AV15PConfig = "SMTP" ;
         /* User Code */
          AV16VConfig = System.Configuration.ConfigurationSettings.AppSettings[AV15PConfig];
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV16VConfig)) )
         {
            AV16VConfig = "172.22.119.135" ;
         }
         AV8SMTP.Host = AV16VConfig ;
         AV8SMTP.Sender.Name = "faxams" ;
         AV8SMTP.Sender.Address = "faxams@sancorsalud.com.ar" ;
         AV8SMTP.Password = "faam825" ;
         AV8SMTP.Login();
         AV8SMTP.AttachDir = "" ;
         AV9MAIL.Clear();
         AV9MAIL.Attachments.Clear();
         AV9MAIL.Subject = AV11ASUNTO ;
         AV9MAIL.To.New("Nestor", "nestor.raimondo@sancorsalud.com.ar");
         AV9MAIL.To.New("Soporte", "proceso.intranet@sancorsalud.com.ar");
         AV9MAIL.Text = AV12MENSAJE ;
         AV8SMTP.Send(AV9MAIL);
         if ( AV8SMTP.ErrCode > 0 )
         {
         }
         AV8SMTP.Logout();
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV10EVENTOch = "" ;
         AV15PConfig = "" ;
         AV16VConfig = "" ;
         AV8SMTP = new GeneXus.Mail.GXSMTPSession();
         AV9MAIL = new GeneXus.Mail.GXMailMessage();
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private String AV11ASUNTO ;
      private String AV12MENSAJE ;
      private String AV10EVENTOch ;
      private String AV15PConfig ;
      private String AV16VConfig ;
      private String aP0_ASUNTO ;
      private String aP1_MENSAJE ;
      private GeneXus.Mail.GXMailMessage AV9MAIL ;
      private GeneXus.Mail.GXSMTPSession AV8SMTP ;
   }

}
