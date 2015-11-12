/*
               File: PMAIL_DIRECCION
        Description: MAIL_ DIRECCION
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/29/2014 16:18:37.59
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
   public class pmail_direccion : GXProcedure
   {
      public pmail_direccion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pmail_direccion( IGxContext context )
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
                           ref String aP3_DIR_MAIL ,
                           ref String aP4_CC_MAIL ,
                           ref String aP5_CCI_MAIL ,
                           ref String aP6_ASUNTO ,
                           ref String aP7_MENSAJE )
      {
         this.AV16SENDER_NAME = aP0_SENDER_NAME;
         this.AV18SENDER_ADDRESS = aP1_SENDER_ADDRESS;
         this.AV17PASSWORD = aP2_PASSWORD;
         this.AV20DIR_MAIL = aP3_DIR_MAIL;
         this.AV19CC_MAIL = aP4_CC_MAIL;
         this.AV21CCI_MAIL = aP5_CCI_MAIL;
         this.AV11ASUNTO = aP6_ASUNTO;
         this.AV12MENSAJE = aP7_MENSAJE;
         initialize();
         executePrivate();
         aP0_SENDER_NAME=this.AV16SENDER_NAME;
         aP1_SENDER_ADDRESS=this.AV18SENDER_ADDRESS;
         aP2_PASSWORD=this.AV17PASSWORD;
         aP3_DIR_MAIL=this.AV20DIR_MAIL;
         aP4_CC_MAIL=this.AV19CC_MAIL;
         aP5_CCI_MAIL=this.AV21CCI_MAIL;
         aP6_ASUNTO=this.AV11ASUNTO;
         aP7_MENSAJE=this.AV12MENSAJE;
      }

      public String executeUdp( ref String aP0_SENDER_NAME ,
                                ref String aP1_SENDER_ADDRESS ,
                                ref String aP2_PASSWORD ,
                                ref String aP3_DIR_MAIL ,
                                ref String aP4_CC_MAIL ,
                                ref String aP5_CCI_MAIL ,
                                ref String aP6_ASUNTO )
      {
         this.AV16SENDER_NAME = aP0_SENDER_NAME;
         this.AV18SENDER_ADDRESS = aP1_SENDER_ADDRESS;
         this.AV17PASSWORD = aP2_PASSWORD;
         this.AV20DIR_MAIL = aP3_DIR_MAIL;
         this.AV19CC_MAIL = aP4_CC_MAIL;
         this.AV21CCI_MAIL = aP5_CCI_MAIL;
         this.AV11ASUNTO = aP6_ASUNTO;
         this.AV12MENSAJE = aP7_MENSAJE;
         initialize();
         executePrivate();
         aP0_SENDER_NAME=this.AV16SENDER_NAME;
         aP1_SENDER_ADDRESS=this.AV18SENDER_ADDRESS;
         aP2_PASSWORD=this.AV17PASSWORD;
         aP3_DIR_MAIL=this.AV20DIR_MAIL;
         aP4_CC_MAIL=this.AV19CC_MAIL;
         aP5_CCI_MAIL=this.AV21CCI_MAIL;
         aP6_ASUNTO=this.AV11ASUNTO;
         aP7_MENSAJE=this.AV12MENSAJE;
         return AV12MENSAJE ;
      }

      public void executeSubmit( ref String aP0_SENDER_NAME ,
                                 ref String aP1_SENDER_ADDRESS ,
                                 ref String aP2_PASSWORD ,
                                 ref String aP3_DIR_MAIL ,
                                 ref String aP4_CC_MAIL ,
                                 ref String aP5_CCI_MAIL ,
                                 ref String aP6_ASUNTO ,
                                 ref String aP7_MENSAJE )
      {
         pmail_direccion objpmail_direccion;
         objpmail_direccion = new pmail_direccion();
         objpmail_direccion.AV16SENDER_NAME = aP0_SENDER_NAME;
         objpmail_direccion.AV18SENDER_ADDRESS = aP1_SENDER_ADDRESS;
         objpmail_direccion.AV17PASSWORD = aP2_PASSWORD;
         objpmail_direccion.AV20DIR_MAIL = aP3_DIR_MAIL;
         objpmail_direccion.AV19CC_MAIL = aP4_CC_MAIL;
         objpmail_direccion.AV21CCI_MAIL = aP5_CCI_MAIL;
         objpmail_direccion.AV11ASUNTO = aP6_ASUNTO;
         objpmail_direccion.AV12MENSAJE = aP7_MENSAJE;
         objpmail_direccion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpmail_direccion.executePrivateCatch ));
         aP0_SENDER_NAME=this.AV16SENDER_NAME;
         aP1_SENDER_ADDRESS=this.AV18SENDER_ADDRESS;
         aP2_PASSWORD=this.AV17PASSWORD;
         aP3_DIR_MAIL=this.AV20DIR_MAIL;
         aP4_CC_MAIL=this.AV19CC_MAIL;
         aP5_CCI_MAIL=this.AV21CCI_MAIL;
         aP6_ASUNTO=this.AV11ASUNTO;
         aP7_MENSAJE=this.AV12MENSAJE;
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
         AV8SMTP.Host = "172.22.119.135" ;
         AV8SMTP.Authentication = 1 ;
         AV8SMTP.UserName = "AMS@insunetweb.com.ar" ;
         AV8SMTP.Sender.Name = AV16SENDER_NAME ;
         AV8SMTP.Sender.Address = AV18SENDER_ADDRESS ;
         AV8SMTP.Password = StringUtil.Trim( AV17PASSWORD) ;
         AV8SMTP.Login();
         AV8SMTP.AttachDir = "" ;
         AV9MAIL.Clear();
         AV9MAIL.Attachments.Clear();
         AV9MAIL.Subject = AV11ASUNTO ;
         AV9MAIL.To.New(" ", AV15PER_MAIL);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19CC_MAIL)) )
         {
            AV9MAIL.To.New("Soporte", AV19CC_MAIL);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21CCI_MAIL)) )
         {
            AV9MAIL.BCC.New("Copia", AV21CCI_MAIL);
         }
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
         AV15PER_MAIL = "" ;
         AV10EVENTOch = "" ;
         AV8SMTP = new GeneXus.Mail.GXSMTPSession();
         AV9MAIL = new GeneXus.Mail.GXMailMessage();
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private String AV16SENDER_NAME ;
      private String AV18SENDER_ADDRESS ;
      private String AV17PASSWORD ;
      private String AV20DIR_MAIL ;
      private String AV19CC_MAIL ;
      private String AV21CCI_MAIL ;
      private String AV11ASUNTO ;
      private String AV15PER_MAIL ;
      private String AV10EVENTOch ;
      private String AV12MENSAJE ;
      private String aP0_SENDER_NAME ;
      private String aP1_SENDER_ADDRESS ;
      private String aP2_PASSWORD ;
      private String aP3_DIR_MAIL ;
      private String aP4_CC_MAIL ;
      private String aP5_CCI_MAIL ;
      private String aP6_ASUNTO ;
      private String aP7_MENSAJE ;
      private GeneXus.Mail.GXMailMessage AV9MAIL ;
      private GeneXus.Mail.GXSMTPSession AV8SMTP ;
   }

}
