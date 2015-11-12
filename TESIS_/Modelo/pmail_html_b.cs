/*
               File: PMAIL_HTML_B
        Description: ENVIO DE MAIL CON ATTACHS EN RPT
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/29/2014 16:18:37.70
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
   public class pmail_html_b : GXProcedure
   {
      public pmail_html_b( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pmail_html_b( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_SENDER_NAME ,
                           ref String aP1_SENDER_ADDRESS ,
                           ref String aP2_PASSWORD ,
                           ref String aP3_DestinatarioNom ,
                           ref String aP4_DIR_MAIL ,
                           ref String aP5_CC_MAIL ,
                           ref String aP6_ASUNTO ,
                           ref String aP7_MENSAJE ,
                           ref GxWebWrapper aP8_WEBWRAPP ,
                           ref IGxCollection aP9_SDTAttachs ,
                           ref String aP10_Gx_emsg )
      {
         this.AV16SENDER_NAME = aP0_SENDER_NAME;
         this.AV18SENDER_ADDRESS = aP1_SENDER_ADDRESS;
         this.AV17PASSWORD = aP2_PASSWORD;
         this.AV25DestinatarioNom = aP3_DestinatarioNom;
         this.AV20DIR_MAIL = aP4_DIR_MAIL;
         this.AV19CC_MAIL = aP5_CC_MAIL;
         this.AV11ASUNTO = aP6_ASUNTO;
         this.AV12MENSAJE = aP7_MENSAJE;
         this.AV21WEBWRAPP = aP8_WEBWRAPP;
         this.AV23SDTAttachs = aP9_SDTAttachs;
         this.Gx_emsg = aP10_Gx_emsg;
         initialize();
         executePrivate();
         aP0_SENDER_NAME=this.AV16SENDER_NAME;
         aP1_SENDER_ADDRESS=this.AV18SENDER_ADDRESS;
         aP2_PASSWORD=this.AV17PASSWORD;
         aP3_DestinatarioNom=this.AV25DestinatarioNom;
         aP4_DIR_MAIL=this.AV20DIR_MAIL;
         aP5_CC_MAIL=this.AV19CC_MAIL;
         aP6_ASUNTO=this.AV11ASUNTO;
         aP7_MENSAJE=this.AV12MENSAJE;
         aP8_WEBWRAPP=this.AV21WEBWRAPP;
         aP9_SDTAttachs=this.AV23SDTAttachs;
         aP10_Gx_emsg=this.Gx_emsg;
      }

      public String executeUdp( ref String aP0_SENDER_NAME ,
                                ref String aP1_SENDER_ADDRESS ,
                                ref String aP2_PASSWORD ,
                                ref String aP3_DestinatarioNom ,
                                ref String aP4_DIR_MAIL ,
                                ref String aP5_CC_MAIL ,
                                ref String aP6_ASUNTO ,
                                ref String aP7_MENSAJE ,
                                ref GxWebWrapper aP8_WEBWRAPP ,
                                ref IGxCollection aP9_SDTAttachs )
      {
         this.AV16SENDER_NAME = aP0_SENDER_NAME;
         this.AV18SENDER_ADDRESS = aP1_SENDER_ADDRESS;
         this.AV17PASSWORD = aP2_PASSWORD;
         this.AV25DestinatarioNom = aP3_DestinatarioNom;
         this.AV20DIR_MAIL = aP4_DIR_MAIL;
         this.AV19CC_MAIL = aP5_CC_MAIL;
         this.AV11ASUNTO = aP6_ASUNTO;
         this.AV12MENSAJE = aP7_MENSAJE;
         this.AV21WEBWRAPP = aP8_WEBWRAPP;
         this.AV23SDTAttachs = aP9_SDTAttachs;
         this.Gx_emsg = aP10_Gx_emsg;
         initialize();
         executePrivate();
         aP0_SENDER_NAME=this.AV16SENDER_NAME;
         aP1_SENDER_ADDRESS=this.AV18SENDER_ADDRESS;
         aP2_PASSWORD=this.AV17PASSWORD;
         aP3_DestinatarioNom=this.AV25DestinatarioNom;
         aP4_DIR_MAIL=this.AV20DIR_MAIL;
         aP5_CC_MAIL=this.AV19CC_MAIL;
         aP6_ASUNTO=this.AV11ASUNTO;
         aP7_MENSAJE=this.AV12MENSAJE;
         aP8_WEBWRAPP=this.AV21WEBWRAPP;
         aP9_SDTAttachs=this.AV23SDTAttachs;
         aP10_Gx_emsg=this.Gx_emsg;
         return Gx_emsg ;
      }

      public void executeSubmit( ref String aP0_SENDER_NAME ,
                                 ref String aP1_SENDER_ADDRESS ,
                                 ref String aP2_PASSWORD ,
                                 ref String aP3_DestinatarioNom ,
                                 ref String aP4_DIR_MAIL ,
                                 ref String aP5_CC_MAIL ,
                                 ref String aP6_ASUNTO ,
                                 ref String aP7_MENSAJE ,
                                 ref GxWebWrapper aP8_WEBWRAPP ,
                                 ref IGxCollection aP9_SDTAttachs ,
                                 ref String aP10_Gx_emsg )
      {
         pmail_html_b objpmail_html_b;
         objpmail_html_b = new pmail_html_b();
         objpmail_html_b.AV16SENDER_NAME = aP0_SENDER_NAME;
         objpmail_html_b.AV18SENDER_ADDRESS = aP1_SENDER_ADDRESS;
         objpmail_html_b.AV17PASSWORD = aP2_PASSWORD;
         objpmail_html_b.AV25DestinatarioNom = aP3_DestinatarioNom;
         objpmail_html_b.AV20DIR_MAIL = aP4_DIR_MAIL;
         objpmail_html_b.AV19CC_MAIL = aP5_CC_MAIL;
         objpmail_html_b.AV11ASUNTO = aP6_ASUNTO;
         objpmail_html_b.AV12MENSAJE = aP7_MENSAJE;
         objpmail_html_b.AV21WEBWRAPP = aP8_WEBWRAPP;
         objpmail_html_b.AV23SDTAttachs = aP9_SDTAttachs;
         objpmail_html_b.Gx_emsg = aP10_Gx_emsg;
         objpmail_html_b.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpmail_html_b.executePrivateCatch ));
         aP0_SENDER_NAME=this.AV16SENDER_NAME;
         aP1_SENDER_ADDRESS=this.AV18SENDER_ADDRESS;
         aP2_PASSWORD=this.AV17PASSWORD;
         aP3_DestinatarioNom=this.AV25DestinatarioNom;
         aP4_DIR_MAIL=this.AV20DIR_MAIL;
         aP5_CC_MAIL=this.AV19CC_MAIL;
         aP6_ASUNTO=this.AV11ASUNTO;
         aP7_MENSAJE=this.AV12MENSAJE;
         aP8_WEBWRAPP=this.AV21WEBWRAPP;
         aP9_SDTAttachs=this.AV23SDTAttachs;
         aP10_Gx_emsg=this.Gx_emsg;
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
         AV15PER_MAIL = AV20DIR_MAIL ;
         AV10EVENTOch = StringUtil.Str( (decimal)(50), 15, 0) ;
         AV10EVENTOch = StringUtil.PadL( AV10EVENTOch, 15, "0") ;
         Gx_emsg = "" ;
         AV8SMTP.Host = "172.22.119.135" ;
         AV8SMTP.Authentication = 1 ;
         AV8SMTP.UserName = "AMS@insunetweb.com.ar" ;
         AV8SMTP.Sender.Name = StringUtil.Trim( AV16SENDER_NAME) ;
         AV8SMTP.Sender.Address = StringUtil.Trim( AV18SENDER_ADDRESS) ;
         AV8SMTP.Password = "ams172" ;
         AV8SMTP.Login();
         AV9MAIL.Clear();
         AV9MAIL.Attachments.Clear();
         AV9MAIL.Subject = AV11ASUNTO ;
         AV9MAIL.To.New(AV25DestinatarioNom, AV15PER_MAIL);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19CC_MAIL)) )
         {
            AV9MAIL.To.New("Con Comunicación", AV19CC_MAIL);
         }
         AV8SMTP.AttachDir = "E:\\INTRANET\\RPT" ;
         AV9MAIL.Text = AV12MENSAJE ;
         AV28GXV1 = 1 ;
         while ( AV28GXV1 <= AV23SDTAttachs.Count )
         {
            AV24SDTAttachsItem = ((SdtSDTAttachs_SDTAttachsItem)AV23SDTAttachs.Item(AV28GXV1)) ;
            AV22NOMBRE_REPORTE = AV24SDTAttachsItem.gxTpr_Nombrearchivo ;
            AV9MAIL.Attachments.Add(AV22NOMBRE_REPORTE);
            AV28GXV1 = (int)(AV28GXV1+1) ;
         }
         AV8SMTP.Send(AV9MAIL);
         if ( AV8SMTP.ErrCode > 0 )
         {
            Gx_emsg = AV8SMTP.ErrDescription ;
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
         AV15PER_MAIL = "" ;
         AV10EVENTOch = "" ;
         AV8SMTP = new GeneXus.Mail.GXSMTPSession();
         AV9MAIL = new GeneXus.Mail.GXMailMessage();
         AV24SDTAttachsItem = new SdtSDTAttachs_SDTAttachsItem(context);
         AV22NOMBRE_REPORTE = "" ;
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int AV28GXV1 ;
      private String AV16SENDER_NAME ;
      private String AV18SENDER_ADDRESS ;
      private String AV17PASSWORD ;
      private String AV20DIR_MAIL ;
      private String AV19CC_MAIL ;
      private String AV11ASUNTO ;
      private String Gx_emsg ;
      private String AV15PER_MAIL ;
      private String AV10EVENTOch ;
      private String AV22NOMBRE_REPORTE ;
      private String AV12MENSAJE ;
      private String AV25DestinatarioNom ;
      private String aP0_SENDER_NAME ;
      private String aP1_SENDER_ADDRESS ;
      private String aP2_PASSWORD ;
      private String aP3_DestinatarioNom ;
      private String aP4_DIR_MAIL ;
      private String aP5_CC_MAIL ;
      private String aP6_ASUNTO ;
      private String aP7_MENSAJE ;
      private GxWebWrapper aP8_WEBWRAPP ;
      private IGxCollection aP9_SDTAttachs ;
      private String aP10_Gx_emsg ;
      private GeneXus.Mail.GXMailMessage AV9MAIL ;
      private GeneXus.Mail.GXSMTPSession AV8SMTP ;
      private GxWebWrapper AV21WEBWRAPP ;
      [ObjectCollection(ItemType=typeof( SdtSDTAttachs_SDTAttachsItem ))]
      private IGxCollection AV23SDTAttachs ;
      private SdtSDTAttachs_SDTAttachsItem AV24SDTAttachsItem ;
   }

}
