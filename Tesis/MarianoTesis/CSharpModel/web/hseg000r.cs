/*
               File: HSEG000R
        Description: Menú Informes Seguridad
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:18:25.29
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
   public class hseg000r : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public hseg000r( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hseg000r( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_SISTEMA ,
                           ref String aP1_USUARIO ,
                           ref int aP2_ID_SESION )
      {
         this.AV6SISTEMA = aP0_SISTEMA;
         this.AV5USUARIO = aP1_USUARIO;
         this.AV9ID_SESION = aP2_ID_SESION;
         executePrivate();
         aP0_SISTEMA=this.AV6SISTEMA;
         aP1_USUARIO=this.AV5USUARIO;
         aP2_ID_SESION=this.AV9ID_SESION;
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
               AV6SISTEMA = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6SISTEMA", AV6SISTEMA);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV5USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USUARIO", AV5USUARIO);
                  AV9ID_SESION = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ID_SESION", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9ID_SESION), 8, 0)));
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
         PA4Y2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START4Y2( ) ;
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
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;margin: 0px;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("hseg000r.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV5USUARIO)) + "," + UrlEncode("" +AV9ID_SESION)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV6SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV5USUARIO));
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
            WE4Y2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT4Y2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HSEG000R" ;
      }

      public override String GetPgmdesc( )
      {
         return "Menú Informes Seguridad" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("hseg000r.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV5USUARIO)) + "," + UrlEncode("" +AV9ID_SESION) ;
      }

      protected void WB4Y0( )
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
            context.WriteHtmlText( "<pre>") ;
            wb_table1_3_4Y2( true) ;
         }
         else
         {
            wb_table1_3_4Y2( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_4Y2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</pre>") ;
            context.WriteHtmlText( "<pre>") ;
            wb_table2_24_4Y2( true) ;
         }
         else
         {
            wb_table2_24_4Y2( false) ;
         }
         return  ;
      }

      protected void wb_table2_24_4Y2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</pre>") ;
         }
         wbLoad = true ;
      }

      protected void START4Y2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Menú Informes Seguridad", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP4Y0( ) ;
      }

      protected void WS4Y2( )
      {
         START4Y2( ) ;
         EVT4Y2( ) ;
      }

      protected void EVT4Y2( )
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
                              /* Execute user event: E114Y2 */
                              E114Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E124Y2 */
                              E124Y2 ();
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

      protected void WE4Y2( )
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

      protected void PA4Y2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavNom_cookie_Internalname ;
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
         RF4Y2( ) ;
         /* End function Refresh */
      }

      protected void RF4Y2( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E124Y2 */
            E124Y2 ();
            WB4Y0( ) ;
         }
      }

      protected void STRUP4Y0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavId_sesion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_sesion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_sesion_Enabled), 5, 0)));
         edtavNom_cookie_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNom_cookie_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNom_cookie_Enabled), 5, 0)));
         edtavId_sesionck_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavId_sesionck_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavId_sesionck_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E114Y2 */
         E114Y2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            AV6SISTEMA = cgiGet( "vSISTEMA") ;
            AV5USUARIO = cgiGet( "vUSUARIO") ;
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
         /* Execute user event: E114Y2 */
         E114Y2 ();
         if (returnInSub) return;
      }

      protected void E114Y2( )
      {
         /* Start Routine */
         tblTable2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTable2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTable2_Visible), 5, 0)));
         AV10SESION.Set("HSEG000_USUARIO", AV5USUARIO);
         AV10SESION.Set("HSEG000_SESION", StringUtil.Str( (decimal)(AV9ID_SESION), 10, 0));
         AV10SESION.Set("HSEG000_CADUCA", StringUtil.Str( (decimal)(30), 10, 0));
         AV11NOM_COOKIE = "KEY_" + StringUtil.Trim( "HSEG000.ASPX") + "_" + StringUtil.Trim( AV5USUARIO) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11NOM_COOKIE", AV11NOM_COOKIE);
         AV13ID_SESIONCK = (int)(NumberUtil.Val( AV10SESION.Get(AV11NOM_COOKIE), ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ID_SESIONCK", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13ID_SESIONCK), 8, 0)));
         if ( ( AV9ID_SESION == AV13ID_SESIONCK ) && ( AV9ID_SESION != 0 ) )
         {
            GX_msglist.addItem("AUTORIZADO");
         }
         else
         {
            GX_msglist.addItem("NO AUTORIZADO");
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV5USUARIO)) )
         {
            AV5USUARIO = context.GetCookie( "USUARIO") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USUARIO", AV5USUARIO);
         }
         else
         {
            AV8A = context.SetCookie( "USUARIO", AV5USUARIO, "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E124Y2( )
      {
         /* Load Routine */
      }

      protected void wb_table2_24_4Y2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            if ( tblTable2_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;" ;
            }
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "background:transparent" ;
            GxWebStd.gx_single_line_edit( context, edtavId_sesion_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9ID_SESION), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtavId_sesion_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV9ID_SESION), "ZZZZZZZ9"), "", 0, edtavId_sesion_Jsonclick, "", 0, 1, 1, false, "right", "HLP_HSEG000R.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "background:transparent" ;
            GxWebStd.gx_single_line_edit( context, edtavNom_cookie_Internalname, StringUtil.RTrim( AV11NOM_COOKIE), "", 30, "chr", 1, "row", 30, 1, edtavNom_cookie_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV11NOM_COOKIE, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(30);\"", 0, edtavNom_cookie_Jsonclick, "", 0, 1, 1, false, "left", "HLP_HSEG000R.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "background:transparent" ;
            GxWebStd.gx_single_line_edit( context, edtavId_sesionck_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13ID_SESIONCK), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtavId_sesionck_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV13ID_SESIONCK), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(33);\"", 0, edtavId_sesionck_Jsonclick, "", 0, 1, 1, false, "right", "HLP_HSEG000R.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:12.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:16px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_24_4Y2e( true) ;
         }
         else
         {
            wb_table2_24_4Y2e( false) ;
         }
      }

      protected void wb_table1_3_4Y2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:23px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:15px\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttButton3_Internalname, "LISTADO ACESOS POR RESPONSABLE", "LISTADO ACESOS POR RESPONSABLE", "", StyleString, ClassString, 1, 1, "rounded", 7, bttButton3_Jsonclick, "'"+""+"'"+",false,"+"'"+"e134y2_client"+"'", TempTags, "", "", "HLP_HSEG000R.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:15px\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttButton_Internalname, "PROGRAMAS POR VERSION", "PROGRAMAS POR VERSION", "", StyleString, ClassString, 1, 1, "rounded", 7, bttButton_Jsonclick, "'"+""+"'"+",false,"+"'"+"e144y2_client"+"'", TempTags, "", "", "HLP_HSEG000R.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttButton4_Internalname, "PROGRAMAS POR VERSION (SOLO ACTIVOS)", "PROGRAMAS POR VERSION (SOLO ACTIVOS)", "", StyleString, ClassString, 1, 1, "rounded", 7, bttButton4_Jsonclick, "'"+""+"'"+",false,"+"'"+"e154y2_client"+"'", TempTags, "", "", "HLP_HSEG000R.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+";height:22px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_4Y2e( true) ;
         }
         else
         {
            wb_table1_3_4Y2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6SISTEMA = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6SISTEMA", AV6SISTEMA);
         AV5USUARIO = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5USUARIO", AV5USUARIO);
         AV9ID_SESION = Convert.ToInt32(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ID_SESION", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9ID_SESION), 8, 0)));
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
         PA4Y2( ) ;
         WS4Y2( ) ;
         WE4Y2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11182545");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("hseg000r.js", "?11182545");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         bttButton3_Internalname = "BUTTON3" ;
         bttButton_Internalname = "BUTTON" ;
         bttButton4_Internalname = "BUTTON4" ;
         tblTable1_Internalname = "TABLE1" ;
         edtavId_sesion_Internalname = "vID_SESION" ;
         edtavNom_cookie_Internalname = "vNOM_COOKIE" ;
         edtavId_sesionck_Internalname = "vID_SESIONCK" ;
         tblTable2_Internalname = "TABLE2" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavId_sesionck_Jsonclick = "" ;
         edtavId_sesionck_Enabled = 1 ;
         edtavNom_cookie_Jsonclick = "" ;
         edtavNom_cookie_Enabled = 1 ;
         edtavId_sesion_Jsonclick = "" ;
         edtavId_sesion_Enabled = 0 ;
         tblTable2_Visible = 1 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Menú Informes Seguridad" ;
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
         wcpOAV6SISTEMA = "" ;
         wcpOAV5USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV10SESION = new GxWebSession( context);
         AV11NOM_COOKIE = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         GXt_char1 = "" ;
         bttButton3_Jsonclick = "" ;
         bttButton_Jsonclick = "" ;
         bttButton4_Jsonclick = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         edtavId_sesion_Enabled = 0 ;
         edtavNom_cookie_Enabled = 0 ;
         edtavId_sesionck_Enabled = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short AV8A ;
      private short nGXWrapped ;
      private int AV9ID_SESION ;
      private int wcpOAV9ID_SESION ;
      private int edtavId_sesion_Enabled ;
      private int edtavNom_cookie_Enabled ;
      private int edtavId_sesionck_Enabled ;
      private int tblTable2_Visible ;
      private int AV13ID_SESIONCK ;
      private int idxLst ;
      private String AV6SISTEMA ;
      private String AV5USUARIO ;
      private String wcpOAV6SISTEMA ;
      private String wcpOAV5USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavNom_cookie_Internalname ;
      private String edtavId_sesion_Internalname ;
      private String edtavId_sesionck_Internalname ;
      private String tblTable2_Internalname ;
      private String AV11NOM_COOKIE ;
      private String sStyleString ;
      private String ClassString ;
      private String StyleString ;
      private String edtavId_sesion_Jsonclick ;
      private String TempTags ;
      private String edtavNom_cookie_Jsonclick ;
      private String edtavId_sesionck_Jsonclick ;
      private String tblTable1_Internalname ;
      private String GXt_char1 ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String bttButton_Internalname ;
      private String bttButton_Jsonclick ;
      private String bttButton4_Internalname ;
      private String bttButton4_Jsonclick ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_SISTEMA ;
      private String aP1_USUARIO ;
      private int aP2_ID_SESION ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxWebSession AV10SESION ;
      private GXWebForm Form ;
   }

}
