/*
               File: HTBUS013
        Description: Generar Listado de Movimientos de bienes de uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:27.0
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class htbus013 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus013( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus013( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_SISTEMA ,
                           ref String aP1_USUARIO )
      {
         this.AV5SISTEMA = aP0_SISTEMA;
         this.AV8USUARIO = aP1_USUARIO;
         executePrivate();
         aP0_SISTEMA=this.AV5SISTEMA;
         aP1_USUARIO=this.AV8USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
            gxfirstwebparm_bkp = gxfirstwebparm ;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( ) ;
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp ;
            }
            if ( ! entryPointCalled )
            {
               AV5SISTEMA = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SISTEMA", AV5SISTEMA);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV8USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USUARIO", AV8USUARIO);
               }
            }
         }
         context.SetTheme("Modern");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mptrazabilidad", "GeneXus.Programs.mptrazabilidad", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA1B2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1B2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?42940");
            context.AddJavascriptSource("gxfxSD.js", "?42940");
            context.AddJavascriptSource("gxtypesSD.js", "?42940");
            context.AddJavascriptSource("gxpopupSD.js", "?42940");
            context.AddJavascriptSource("gxfrmutlSD.js", "?42940");
            context.AddJavascriptSource("gxgridSD.js", "?42940");
            context.AddJavascriptSource("JavaScripTableSD.js", "?42940");
            context.AddJavascriptSource("rijndaelSD.js", "?42940");
            context.AddJavascriptSource("gxgralSD.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus013.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV5SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV5SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV8USUARIO));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE1B2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1B2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS013" ;
      }

      public override String GetPgmdesc( )
      {
         return "Generar Listado de Movimientos de bienes de uso" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus013.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV5SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) ;
      }

      protected void WB1B0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            wb_table1_2_1B2( true) ;
         }
         else
         {
            wb_table1_2_1B2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1B2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1B2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Generar Listado de Movimientos de bienes de uso", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1B0( ) ;
      }

      protected void WS1B2( )
      {
         START1B2( ) ;
         EVT1B2( ) ;
      }

      protected void EVT1B2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E111B2 */
                              E111B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VTTBUS7_POS.ISVALID") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E121B2 */
                              E121B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VTTBUS7_CODRESP.ISVALID") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E131B2 */
                              E131B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'GENERAR LISTADO'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E141B2 */
                              E141B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E151B2 */
                              E151B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1 ;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false ;
                                 if ( ! Rfr0gs )
                                 {
                                 }
                                 dynload_actions( ) ;
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE1B2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA1B2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavTtbus7_pos_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF1B2( ) ;
         /* End function Refresh */
      }

      protected void RF1B2( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E151B2 */
            E151B2 ();
            WB1B0( ) ;
         }
      }

      protected void STRUP1B0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         imgprompt_Ttbus7_pos_Link = "javascript:"+"gx.popup.openPrompt('"+"htbus013_prompt1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"vTTBUS7_POS"+"'), id:'"+"vTTBUS7_POS"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");" ;
         imgprompt_Ttbus7_codresp_Link = "javascript:"+"gx.popup.openPrompt('"+"htbus013_prompt2.aspx"+"',["+"{Ctrl:gx.dom.el('"+"vTTBUS7_CODRESP"+"'), id:'"+"vTTBUS7_CODRESP"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");" ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E111B2 */
         E111B2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavTtbus7_pos_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavTtbus7_pos_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavTtbus7_pos_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vTTBUS7_POS");
               GX_FocusControl = edtavTtbus7_pos_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7TTBUS7_Pos = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7TTBUS7_Pos), 3, 0)));
            }
            else
            {
               AV7TTBUS7_Pos = (short)(context.localUtil.CToN( cgiGet( edtavTtbus7_pos_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7TTBUS7_Pos), 3, 0)));
            }
            AV10TTBUS7_Des = cgiGet( edtavTtbus7_des_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10TTBUS7_Des", AV10TTBUS7_Des);
            AV6TTBUS7_CodResp = StringUtil.Upper( cgiGet( edtavTtbus7_codresp_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6TTBUS7_CodResp", AV6TTBUS7_CodResp);
            AV9USU_DES = StringUtil.Upper( cgiGet( edtavUsu_des_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9USU_DES", AV9USU_DES);
            /* Read saved values. */
            AV5SISTEMA = cgiGet( "vSISTEMA") ;
            AV8USUARIO = cgiGet( "vUSUARIO") ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E111B2 */
         E111B2 ();
         if (returnInSub) return;
      }

      protected void E111B2( )
      {
         /* Start Routine */
         edtavTtbus7_des_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus7_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus7_des_Enabled), 5, 0)));
         edtavUsu_des_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUsu_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUsu_des_Enabled), 5, 0)));
         AV11SESION.Set("USUARIO", AV8USUARIO);
         new loadcontext(context ).execute( out  AV15Context) ;
         AV8USUARIO = AV15Context.gxTpr_User ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USUARIO", AV8USUARIO);
      }

      protected void E121B2( )
      {
         /* Ttbus7_pos_Isvalid Routine */
         if ( AV7TTBUS7_Pos != 0 )
         {
            AV11SESION.Set("Pos", StringUtil.Str( (decimal)(AV7TTBUS7_Pos), 3, 0));
            /* Using cursor H001B2 */
            pr_default.execute(0, new Object[] {AV7TTBUS7_Pos});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A33TTBUS7_Pos = H001B2_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A34TTBUS7_Des = H001B2_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001B2_n34TTBUS7_Des[0] ;
               A34TTBUS7_Des = H001B2_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001B2_n34TTBUS7_Des[0] ;
               AV10TTBUS7_Des = A34TTBUS7_Des ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10TTBUS7_Des", AV10TTBUS7_Des);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
         }
         else
         {
            AV11SESION.Set("Pos", "0");
            AV10TTBUS7_Des = "" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10TTBUS7_Des", AV10TTBUS7_Des);
         }
      }

      protected void E131B2( )
      {
         /* Ttbus7_codresp_Isvalid Routine */
         if ( StringUtil.StrCmp(StringUtil.Trim( AV6TTBUS7_CodResp), "") != 0 )
         {
            AV11SESION.Set("Resp", AV6TTBUS7_CodResp);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6TTBUS7_CodResp", AV6TTBUS7_CodResp);
            /* Using cursor H001B3 */
            pr_default.execute(1, new Object[] {AV6TTBUS7_CodResp});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A6USU_COD = H001B3_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A7USU_DES = H001B3_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               AV9USU_DES = A7USU_DES ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9USU_DES", AV9USU_DES);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
         }
         else
         {
            AV11SESION.Set("Resp", "");
            AV9USU_DES = "" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9USU_DES", AV9USU_DES);
         }
      }

      protected void E141B2( )
      {
         /* 'Generar Listado' Routine */
         GXt_char3 = "pdf" ;
         new prep000(context ).execute( ref  AV14NOMBRE_REPORTE, ref  GXt_char3) ;
         context.wjLoc = formatLink("aptbus013.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14NOMBRE_REPORTE)) + "," + UrlEncode(StringUtil.RTrim(AV8USUARIO)) + "," + UrlEncode("" +AV7TTBUS7_Pos) + "," + UrlEncode(StringUtil.RTrim(AV6TTBUS7_CodResp)) ;
      }

      protected void nextLoad( )
      {
      }

      protected void E151B2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_1B2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(161), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(517), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            wb_table2_10_1B2( true) ;
         }
         else
         {
            wb_table2_10_1B2( false) ;
         }
         return  ;
      }

      protected void wb_table2_10_1B2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Generar Listado", "Generar Listado", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'GENERAR LISTADO\\'.", TempTags, "", "", "HLP_HTBUS013.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1B2e( true) ;
         }
         else
         {
            wb_table1_2_1B2e( false) ;
         }
      }

      protected void wb_table2_10_1B2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(48), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(488), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"width:3px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Posición:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS013.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus7_pos_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7TTBUS7_Pos), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV7TTBUS7_Pos), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(15);\"", 0, edtavTtbus7_pos_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HTBUS013.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_Ttbus7_pos_Internalname, "", "prompt.gif", "Modern", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_Ttbus7_pos_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_HTBUS013.htm");
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus7_des_Internalname, StringUtil.RTrim( AV10TTBUS7_Des), "", 50, "chr", 1, "row", 50, 1, edtavTtbus7_des_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV10TTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(16);\"", 0, edtavTtbus7_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUS013.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Responsable:", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS013.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus7_codresp_Internalname, StringUtil.RTrim( AV6TTBUS7_CodResp), "", 16, "chr", 1, "row", 16, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV6TTBUS7_CodResp, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(21);\"", 0, edtavTtbus7_codresp_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUS013.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_Ttbus7_codresp_Internalname, "", "prompt.gif", "Modern", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_Ttbus7_codresp_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_HTBUS013.htm");
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavUsu_des_Internalname, StringUtil.RTrim( AV9USU_DES), "", 50, "chr", 1, "row", 50, 1, edtavUsu_des_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV9USU_DES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(22);\"", 0, edtavUsu_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUS013.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_10_1B2e( true) ;
         }
         else
         {
            wb_table2_10_1B2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV5SISTEMA = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SISTEMA", AV5SISTEMA);
         AV8USUARIO = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8USUARIO", AV8USUARIO);
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA1B2( ) ;
         WS1B2( ) ;
         WE1B2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19292720");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("htbus013.js", "?19292720");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavTtbus7_pos_Internalname = "vTTBUS7_POS" ;
         edtavTtbus7_des_Internalname = "vTTBUS7_DES" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtavTtbus7_codresp_Internalname = "vTTBUS7_CODRESP" ;
         edtavUsu_des_Internalname = "vUSU_DES" ;
         tblTable2_Internalname = "TABLE2" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         imgprompt_Ttbus7_pos_Internalname = "PROMPT_TTBUS7_POS" ;
         imgprompt_Ttbus7_codresp_Internalname = "PROMPT_TTBUS7_CODRESP" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavUsu_des_Jsonclick = "" ;
         imgprompt_Ttbus7_codresp_Link = "" ;
         edtavTtbus7_codresp_Jsonclick = "" ;
         edtavTtbus7_des_Jsonclick = "" ;
         imgprompt_Ttbus7_pos_Link = "" ;
         edtavTtbus7_pos_Jsonclick = "" ;
         edtavUsu_des_Enabled = 1 ;
         edtavTtbus7_des_Enabled = 1 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Generar Listado de Movimientos de bienes de uso" ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         wcpOAV5SISTEMA = "" ;
         wcpOAV8USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV10TTBUS7_Des = "" ;
         AV6TTBUS7_CodResp = "" ;
         AV9USU_DES = "" ;
         AV11SESION = new GxWebSession( context);
         AV15Context = new SdtContext(context);
         scmdbuf = "" ;
         H001B2_A33TTBUS7_Pos = new short[1] ;
         H001B2_A34TTBUS7_Des = new String[] {""} ;
         H001B2_n34TTBUS7_Des = new bool[] {false} ;
         A34TTBUS7_Des = "" ;
         H001B3_A6USU_COD = new String[] {""} ;
         H001B3_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         AV14NOMBRE_REPORTE = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         GXt_char3 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus013__default(),
            new Object[][] {
                new Object[] {
               H001B2_A33TTBUS7_Pos, H001B2_A34TTBUS7_Des, H001B2_n34TTBUS7_Des
               }
               , new Object[] {
               H001B3_A6USU_COD, H001B3_A7USU_DES
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         imgprompt_Ttbus7_pos_Link = "javascript:"+"gx.popup.openPrompt('"+"htbus013_prompt1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"vTTBUS7_POS"+"'), id:'"+"vTTBUS7_POS"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");" ;
         imgprompt_Ttbus7_codresp_Link = "javascript:"+"gx.popup.openPrompt('"+"htbus013_prompt2.aspx"+"',["+"{Ctrl:gx.dom.el('"+"vTTBUS7_CODRESP"+"'), id:'"+"vTTBUS7_CODRESP"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");" ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short AV7TTBUS7_Pos ;
      private short A33TTBUS7_Pos ;
      private short nGXWrapped ;
      private int edtavTtbus7_des_Enabled ;
      private int edtavUsu_des_Enabled ;
      private int idxLst ;
      private String AV5SISTEMA ;
      private String AV8USUARIO ;
      private String wcpOAV5SISTEMA ;
      private String wcpOAV8USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavTtbus7_pos_Internalname ;
      private String imgprompt_Ttbus7_pos_Link ;
      private String imgprompt_Ttbus7_codresp_Link ;
      private String AV10TTBUS7_Des ;
      private String edtavTtbus7_des_Internalname ;
      private String AV6TTBUS7_CodResp ;
      private String edtavTtbus7_codresp_Internalname ;
      private String AV9USU_DES ;
      private String edtavUsu_des_Internalname ;
      private String scmdbuf ;
      private String A34TTBUS7_Des ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String AV14NOMBRE_REPORTE ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavTtbus7_pos_Jsonclick ;
      private String imgprompt_Ttbus7_pos_Internalname ;
      private String edtavTtbus7_des_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtavTtbus7_codresp_Jsonclick ;
      private String imgprompt_Ttbus7_codresp_Internalname ;
      private String edtavUsu_des_Jsonclick ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool n34TTBUS7_Des ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private String aP0_SISTEMA ;
      private String aP1_USUARIO ;
      private IDataStoreProvider pr_default ;
      private short[] H001B2_A33TTBUS7_Pos ;
      private String[] H001B2_A34TTBUS7_Des ;
      private bool[] H001B2_n34TTBUS7_Des ;
      private String[] H001B3_A6USU_COD ;
      private String[] H001B3_A7USU_DES ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxWebSession AV11SESION ;
      private GXWebForm Form ;
      private SdtContext AV15Context ;
   }

   public class htbus013__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001B2 ;
          prmH001B2 = new Object[] {
          new Object[] {"@AV7TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001B3 ;
          prmH001B3 = new Object[] {
          new Object[] {"@AV6TTBUS7_CodResp",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001B2", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @AV7TTBUS7_Pos ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001B2,1,0,false,true )
             ,new CursorDef("H001B3", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV6TTBUS7_CodResp ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001B3,1,0,false,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
