/*
               File: HSEG002
        Description: Agrega Programas
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:18:27.16
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
   public class hseg002 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public hseg002( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hseg002( IGxContext context )
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

      public void execute( ref String aP0_USUCOD ,
                           ref short aP1_SISCOD ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV6USUCOD = aP0_USUCOD;
         this.AV5SISCOD = aP1_SISCOD;
         this.AV9SISTEMA = aP2_SISTEMA;
         this.AV10USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_USUCOD=this.AV6USUCOD;
         aP1_SISCOD=this.AV5SISCOD;
         aP2_SISTEMA=this.AV9SISTEMA;
         aP3_USUARIO=this.AV10USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavMarca = new GXCheckbox();
         cmbPRG_EXT = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_12_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_12_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_12_idx, sGXsfl_12_idx) ;
               return  ;
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
               AV6USUCOD = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUCOD", AV6USUCOD);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV5SISCOD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SISCOD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5SISCOD), 3, 0)));
                  AV9SISTEMA = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SISTEMA", AV9SISTEMA);
                  AV10USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USUARIO", AV10USUARIO);
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
         PA542( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START542( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("hseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6USUCOD)) + "," + UrlEncode("" +AV5SISCOD) + "," + UrlEncode(StringUtil.RTrim(AV9SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV10USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vPRGDES", StringUtil.RTrim( AV7PRGDES));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV6USUCOD));
         GxWebStd.gx_hidden_field( context, "vSISCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5SISCOD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV9SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV10USUARIO));
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
            WE542( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT542( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HSEG002" ;
      }

      public override String GetPgmdesc( )
      {
         return "Agrega Programas" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("hseg002.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6USUCOD)) + "," + UrlEncode("" +AV5SISCOD) + "," + UrlEncode(StringUtil.RTrim(AV9SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV10USUARIO)) ;
      }

      protected void WB540( )
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            context.WriteHtmlText( "<pre>") ;
            wb_table1_3_542( true) ;
         }
         else
         {
            wb_table1_3_542( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_542e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<center/>") ;
            context.WriteHtmlText( "</pre>") ;
         }
         wbLoad = true ;
      }

      protected void START542( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Agrega Programas", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP540( ) ;
      }

      protected void WS542( )
      {
         START542( ) ;
         EVT542( ) ;
      }

      protected void EVT542( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'CONFIRMA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11542 */
                              E11542 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'VOLVER'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12542 */
                              E12542 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'CONFIRMA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'VOLVER'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
                              chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
                              edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_12_idx ;
                              edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_12_idx ;
                              cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_12_idx ;
                              edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_12_idx ;
                              edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_12_idx ;
                              AV8MARCA = ((StringUtil.StrCmp(cgiGet( chkavMarca_Internalname), "*")==0) ? "*" : "' '") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8MARCA", AV8MARCA);
                              A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                              A127PRG_DES = cgiGet( edtPRG_DES_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
                              cmbPRG_EXT.Name = cmbPRG_EXT_Internalname ;
                              cmbPRG_EXT.CurrentValue = cgiGet( cmbPRG_EXT_Internalname) ;
                              A128PRG_EXT = cgiGet( cmbPRG_EXT_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
                              A117PRG_WEB = cgiGet( edtPRG_WEB_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117PRG_WEB", A117PRG_WEB);
                              A164PRG_SIS = (short)(context.localUtil.CToN( cgiGet( edtPRG_SIS_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E13542 */
                                    E13542 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'CONFIRMA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11542 */
                                    E11542 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'VOLVER'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12542 */
                                    E12542 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Prgdes Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPRGDES"), AV7PRGDES) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
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
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE542( )
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

      protected void PA542( )
      {
         if ( nDonePA == 0 )
         {
            GXCCtl = "vMARCA_" + sGXsfl_12_idx ;
            chkavMarca.Name = GXCCtl ;
            chkavMarca.WebTags = "" ;
            chkavMarca.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavMarca_Internalname, "Caption", chkavMarca.Caption);
            chkavMarca.CheckedValue = "' '" ;
            GXCCtl = "PRG_EXT_" + sGXsfl_12_idx ;
            cmbPRG_EXT.Name = GXCCtl ;
            cmbPRG_EXT.WebTags = "" ;
            if ( ( cmbPRG_EXT.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A128PRG_EXT)) )
            {
               A128PRG_EXT = cmbPRG_EXT.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
            }
            GX_FocusControl = edtavPrgdes_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_12_idx ,
                                       String sGXsfl_12_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
         edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_12_idx ;
         edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_12_idx ;
         cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_12_idx ;
         edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_12_idx ;
         edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_12_idx ;
         while ( nGXsfl_12_idx <= nRC_Grid1 )
         {
            sendrow_122( ) ;
            nGXsfl_12_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1)) ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_12_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_12_idx ;
            cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_12_idx ;
            edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_12_idx ;
            edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_12_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void Refresh( )
      {
         RF542( ) ;
         /* End function Refresh */
      }

      protected void RF542( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 12 ;
         nGXsfl_12_idx = 1 ;
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
         chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
         edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_12_idx ;
         edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_12_idx ;
         cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_12_idx ;
         edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_12_idx ;
         edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_12_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_12_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_12_idx ;
            cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_12_idx ;
            edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_12_idx ;
            edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_12_idx ;
            /* Using cursor H00542 */
            pr_default.execute(0, new Object[] {AV7PRGDES, AV5SISCOD});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A164PRG_SIS = H00542_A164PRG_SIS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
               A117PRG_WEB = H00542_A117PRG_WEB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117PRG_WEB", A117PRG_WEB);
               A128PRG_EXT = H00542_A128PRG_EXT[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
               A127PRG_DES = H00542_A127PRG_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
               A126PRG_COD = H00542_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               /* Execute user event: E13542 */
               E13542 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 12 ;
            WB540( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP540( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV7PRGDES = StringUtil.Upper( cgiGet( edtavPrgdes_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PRGDES", AV7PRGDES);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV6USUCOD = cgiGet( "vUSUCOD") ;
            AV5SISCOD = (short)(context.localUtil.CToN( cgiGet( "vSISCOD"), ",", ".")) ;
            AV9SISTEMA = cgiGet( "vSISTEMA") ;
            AV10USUARIO = cgiGet( "vUSUARIO") ;
            /* Read subfile selected row values. */
            nGXsfl_12_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ",", ".")) ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_12_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_12_idx ;
            cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_12_idx ;
            edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_12_idx ;
            edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_12_idx ;
            if ( nGXsfl_12_idx > 0 )
            {
               AV8MARCA = ((StringUtil.StrCmp(cgiGet( chkavMarca_Internalname), "*")==0) ? "*" : "' '") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8MARCA", AV8MARCA);
               A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A127PRG_DES = cgiGet( edtPRG_DES_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
               cmbPRG_EXT.Name = cmbPRG_EXT_Internalname ;
               cmbPRG_EXT.CurrentValue = cgiGet( cmbPRG_EXT_Internalname) ;
               A128PRG_EXT = cgiGet( cmbPRG_EXT_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
               A117PRG_WEB = cgiGet( edtPRG_WEB_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117PRG_WEB", A117PRG_WEB);
               A164PRG_SIS = (short)(context.localUtil.CToN( cgiGet( edtPRG_SIS_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
            }
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      private void E13542( )
      {
         /* Load Routine */
         if ( StringUtil.StrCmp(A128PRG_EXT, "B") == 0 )
         {
            edtPRG_COD_Forecolor = GXUtil.RGB( 255, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Forecolor), 9, 0)));
            edtPRG_COD_Fontbold = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Fontbold", StringUtil.Str( (decimal)(edtPRG_COD_Fontbold), 1, 0));
            edtPRG_DES_Forecolor = GXUtil.RGB( 255, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_DES_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_DES_Forecolor), 9, 0)));
            edtPRG_DES_Fontbold = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_DES_Internalname, "Fontbold", StringUtil.Str( (decimal)(edtPRG_DES_Fontbold), 1, 0));
            edtPRG_WEB_Forecolor = GXUtil.RGB( 255, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_WEB_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_WEB_Forecolor), 9, 0)));
            edtPRG_WEB_Fontbold = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_WEB_Internalname, "Fontbold", StringUtil.Str( (decimal)(edtPRG_WEB_Fontbold), 1, 0));
         }
         else
         {
            edtPRG_COD_Forecolor = GXUtil.RGB( 0, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Forecolor), 9, 0)));
            edtPRG_COD_Fontbold = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Fontbold", StringUtil.Str( (decimal)(edtPRG_COD_Fontbold), 1, 0));
            edtPRG_DES_Forecolor = GXUtil.RGB( 0, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_DES_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_DES_Forecolor), 9, 0)));
            edtPRG_DES_Fontbold = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_DES_Internalname, "Fontbold", StringUtil.Str( (decimal)(edtPRG_DES_Fontbold), 1, 0));
            edtPRG_WEB_Forecolor = GXUtil.RGB( 0, 0, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_WEB_Internalname, "Forecolor", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_WEB_Forecolor), 9, 0)));
            edtPRG_WEB_Fontbold = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_WEB_Internalname, "Fontbold", StringUtil.Str( (decimal)(edtPRG_WEB_Fontbold), 1, 0));
         }
         AV8MARCA = " " ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8MARCA", AV8MARCA);
         sendrow_122( ) ;
      }

      protected void E11542( )
      {
         /* 'Confirma' Routine */
         /* Start For Each Line */
         nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
         nGXsfl_12_fel_idx = 0 ;
         while ( nGXsfl_12_fel_idx < nRC_Grid1 )
         {
            nGXsfl_12_fel_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_12_fel_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_12_fel_idx+1)) ;
            sGXsfl_12_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_fel_idx), 4, 0)), 4, "0") ;
            chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_fel_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_12_fel_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_12_fel_idx ;
            cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_12_fel_idx ;
            edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_12_fel_idx ;
            edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_12_fel_idx ;
            AV8MARCA = ((StringUtil.StrCmp(cgiGet( chkavMarca_Internalname), "*")==0) ? "*" : "' '") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8MARCA", AV8MARCA);
            A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A127PRG_DES = cgiGet( edtPRG_DES_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            cmbPRG_EXT.Name = cmbPRG_EXT_Internalname ;
            cmbPRG_EXT.CurrentValue = cgiGet( cmbPRG_EXT_Internalname) ;
            A128PRG_EXT = cgiGet( cmbPRG_EXT_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
            A117PRG_WEB = cgiGet( edtPRG_WEB_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117PRG_WEB", A117PRG_WEB);
            A164PRG_SIS = (short)(context.localUtil.CToN( cgiGet( edtPRG_SIS_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164PRG_SIS", StringUtil.LTrim( StringUtil.Str( (decimal)(A164PRG_SIS), 3, 0)));
            if ( StringUtil.StrCmp(AV8MARCA, "*") == 0 )
            {
               new pseg002(context ).execute( ref  AV6USUCOD, ref  AV5SISCOD, ref  A126PRG_COD) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUCOD", AV6USUCOD);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SISCOD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5SISCOD), 3, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            }
            /* End For Each Line */
         }
         if ( nGXsfl_12_fel_idx == 0 )
         {
            nGXsfl_12_idx = 1 ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
            edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_12_idx ;
            edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_12_idx ;
            cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_12_idx ;
            edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_12_idx ;
            edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_12_idx ;
         }
         nGXsfl_12_fel_idx = 1 ;
         context.setWebReturnParms(new Object[] {(String)AV6USUCOD,(short)AV5SISCOD,(String)AV9SISTEMA,(String)AV10USUARIO});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void E12542( )
      {
         /* 'Volver' Routine */
         context.wjLoc = formatLink("hseg102.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV9SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV10USUARIO)) ;
      }

      protected void wb_table1_3_542( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Programa:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HSEG002.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 7,'',false,'" + sGXsfl_12_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavPrgdes_Internalname, StringUtil.RTrim( AV7PRGDES), "", 30, "chr", 1, "row", 30, 1, edtavPrgdes_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV7PRGDES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(7);\"", 0, edtavPrgdes_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HSEG002.htm");
            context.WriteHtmlText( "&nbsp;&nbsp;&nbsp; ") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttButton2_Internalname, "Buscar", "Buscar", "", StyleString, ClassString, 1, 1, "rounded", 7, bttButton2_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14542_client"+"'", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td valign=\"top\"  style=\"text-align:"+context.GetCssProperty( "Align", "left")+"\">") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1 ;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor ;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:normal; font-style:normal; color:#000000"+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:normal; font-style:normal; color:#000000"+"\" "+">") ;
               context.SendWebValue( "Programa") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Entorno Publicación") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nombre Objeto Web") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "CODIGO DE SISTEMA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid1Container.Clear();
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV8MARCA));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ".", "")));
               Grid1Column.AddObjectProperty("Forecolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRG_COD_Forecolor), 9, 0, ".", "")));
               Grid1Column.AddObjectProperty("Fontbold", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRG_COD_Fontbold), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A127PRG_DES));
               Grid1Column.AddObjectProperty("Forecolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRG_DES_Forecolor), 9, 0, ".", "")));
               Grid1Column.AddObjectProperty("Fontbold", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRG_DES_Fontbold), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A128PRG_EXT));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A117PRG_WEB));
               Grid1Column.AddObjectProperty("Forecolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRG_WEB_Forecolor), 9, 0, ".", "")));
               Grid1Column.AddObjectProperty("Fontbold", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPRG_WEB_Fontbold), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A164PRG_SIS), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "true");
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", "true");
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 12 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_12_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table2_21_542( true) ;
         }
         else
         {
            wb_table2_21_542( false) ;
         }
         return  ;
      }

      protected void wb_table2_21_542e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_542e( true) ;
         }
         else
         {
            wb_table1_3_542e( false) ;
         }
      }

      protected void wb_table2_21_542( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Confirma", "Confirma", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'CONFIRMA\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Salir", "Salir", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_cancel_Jsonclick, "E\\'VOLVER\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_21_542e( true) ;
         }
         else
         {
            wb_table2_21_542e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6USUCOD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUCOD", AV6USUCOD);
         AV5SISCOD = Convert.ToInt16(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SISCOD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5SISCOD), 3, 0)));
         AV9SISTEMA = (String)getParm(obj,2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SISTEMA", AV9SISTEMA);
         AV10USUARIO = (String)getParm(obj,3) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USUARIO", AV10USUARIO);
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
         PA542( ) ;
         WS542( ) ;
         WE542( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11182757");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("hseg002.js", "?11182757");
         /* End function include_jscripts */
      }

      protected void sendrow_122( )
      {
         WB540( ) ;
         Grid1Row = GXWebRow.GetNew(context,Grid1Container) ;
         if ( subGrid1_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid1_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd" ;
            }
         }
         else if ( subGrid1_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid1_Backstyle = 0 ;
            subGrid1_Backcolor = subGrid1_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Uniform" ;
            }
         }
         else if ( subGrid1_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid1_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd" ;
            }
            subGrid1_Backcolor = (int)(0xF0F0F0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
         }
         else if ( subGrid1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid1_Backstyle = 1 ;
            if ( ((int)(nGXsfl_12_idx) % (2)) == 0 )
            {
               subGrid1_Backcolor = (int)(0xE5E5E5) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Even" ;
               }
            }
            else
            {
               subGrid1_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
            }
         }
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( ">") ;
         }
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavMarca.Enabled!=0)&&(chkavMarca.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 13,'',false,'"+sGXsfl_12_idx+"',12)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:normal; font-style:normal; color:#000000" ;
         Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavMarca_Internalname,(String)AV8MARCA,(String)"",(short)-1,(short)1,(String)"*",(String)"",(String)StyleString,(String)ClassString,TempTags+((chkavMarca.Enabled!=0)&&(chkavMarca.Visible!=0) ? " onclick=\"gx.fn.checkboxClick(13, this, '*', '' '');gx.evt.onchange(this);\" " : " ")+((chkavMarca.Enabled!=0)&&(chkavMarca.Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(13);\"" : " ")});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = ((edtPRG_COD_Fontbold==1) ? "font-weight:bold;" : "font-weight:normal;") + "color:" + context.BuildHTMLColor( edtPRG_COD_Forecolor) + ";" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"),(String)"",(short)0,(String)edtPRG_COD_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = ((edtPRG_DES_Fontbold==1) ? "font-weight:bold;" : "font-weight:normal;") + "color:" + context.BuildHTMLColor( edtPRG_DES_Forecolor) + ";" + "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-style:normal" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_DES_Internalname,StringUtil.RTrim( A127PRG_DES),(String)"",(short)217,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)1,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRG_DES_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         ClassString = "Attribute" ;
         StyleString = "" ;
         if ( ( nGXsfl_12_idx == 1 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "PRG_EXT_" + sGXsfl_12_idx ;
            cmbPRG_EXT.Name = GXCCtl ;
            cmbPRG_EXT.WebTags = "" ;
            if ( ( cmbPRG_EXT.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A128PRG_EXT)) )
            {
               A128PRG_EXT = cmbPRG_EXT.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128PRG_EXT", A128PRG_EXT);
            }
         }
         /* ComboBox */
         Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPRG_EXT,(String)cmbPRG_EXT_Internalname,(String)A128PRG_EXT,(String)"",(String)"char",(short)-1,(short)0,(short)0,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbPRG_EXT_Jsonclick,(String)"",(String)"",(bool)true});
         cmbPRG_EXT.CurrentValue = A128PRG_EXT ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPRG_EXT_Internalname, "Values", (String)(cmbPRG_EXT.ToJavascriptSource()));
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = ((edtPRG_WEB_Fontbold==1) ? "font-weight:bold;" : "font-weight:normal;") + "color:" + context.BuildHTMLColor( edtPRG_WEB_Forecolor) + ";" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_WEB_Internalname,StringUtil.RTrim( A117PRG_WEB),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A117PRG_WEB, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtPRG_WEB_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPRG_SIS_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A164PRG_SIS), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A164PRG_SIS), "ZZ9"),(String)"",(short)0,(String)edtPRG_SIS_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_12_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1)) ;
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
         chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
         edtPRG_COD_Internalname = "PRG_COD_"+sGXsfl_12_idx ;
         edtPRG_DES_Internalname = "PRG_DES_"+sGXsfl_12_idx ;
         cmbPRG_EXT_Internalname = "PRG_EXT_"+sGXsfl_12_idx ;
         edtPRG_WEB_Internalname = "PRG_WEB_"+sGXsfl_12_idx ;
         edtPRG_SIS_Internalname = "PRG_SIS_"+sGXsfl_12_idx ;
         /* End function sendrow_122 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavPrgdes_Internalname = "vPRGDES" ;
         bttButton2_Internalname = "BUTTON2" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable2_Internalname = "TABLE2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtPRG_SIS_Jsonclick = "" ;
         edtPRG_WEB_Jsonclick = "" ;
         cmbPRG_EXT_Jsonclick = "" ;
         edtPRG_DES_Jsonclick = "" ;
         edtPRG_COD_Jsonclick = "" ;
         chkavMarca.Visible = -1 ;
         chkavMarca.Enabled = 1 ;
         subGrid1_Hoveringcolor = (int)(0x00C0C0) ;
         subGrid1_Selectioncolor = (int)(0x80FFFF) ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         edtavPrgdes_Jsonclick = "" ;
         edtavPrgdes_Enabled = 1 ;
         edtPRG_WEB_Fontbold = 0 ;
         edtPRG_WEB_Forecolor = (int)(0x000000) ;
         edtPRG_DES_Fontbold = 0 ;
         edtPRG_DES_Forecolor = (int)(0x000000) ;
         edtPRG_COD_Fontbold = 0 ;
         edtPRG_COD_Forecolor = (int)(0x000000) ;
         chkavMarca.Caption = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Agrega Programas" ;
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
         wcpOAV6USUCOD = "" ;
         wcpOAV9SISTEMA = "" ;
         wcpOAV10USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         AV7PRGDES = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         chkavMarca_Internalname = "" ;
         edtPRG_COD_Internalname = "" ;
         edtPRG_DES_Internalname = "" ;
         cmbPRG_EXT_Internalname = "" ;
         edtPRG_WEB_Internalname = "" ;
         edtPRG_SIS_Internalname = "" ;
         AV8MARCA = "" ;
         A127PRG_DES = "" ;
         A128PRG_EXT = "" ;
         A117PRG_WEB = "" ;
         GXCCtl = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         H00542_A164PRG_SIS = new short[1] ;
         H00542_A117PRG_WEB = new String[] {""} ;
         H00542_A128PRG_EXT = new String[] {""} ;
         H00542_A127PRG_DES = new String[] {""} ;
         H00542_A126PRG_COD = new short[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         TempTags = "" ;
         bttButton2_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char5 = "" ;
         bttButton1_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char6 = "" ;
         ROClassString = "" ;
         GXt_char7 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hseg002__default(),
            new Object[][] {
                new Object[] {
               H00542_A164PRG_SIS, H00542_A117PRG_WEB, H00542_A128PRG_EXT, H00542_A127PRG_DES, H00542_A126PRG_COD
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV5SISCOD ;
      private short wcpOAV5SISCOD ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_12_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short A126PRG_COD ;
      private short A164PRG_SIS ;
      private short nDonePA ;
      private short edtPRG_COD_Fontbold ;
      private short edtPRG_DES_Fontbold ;
      private short edtPRG_WEB_Fontbold ;
      private short nGXsfl_12_fel_idx=1 ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Islastpage ;
      private int GRID1_nFirstRecordOnPage ;
      private int GRID1_nCurrentRecord ;
      private int edtPRG_COD_Forecolor ;
      private int edtPRG_DES_Forecolor ;
      private int edtPRG_WEB_Forecolor ;
      private int edtavPrgdes_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String AV6USUCOD ;
      private String AV9SISTEMA ;
      private String AV10USUARIO ;
      private String wcpOAV6USUCOD ;
      private String wcpOAV9SISTEMA ;
      private String wcpOAV10USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String AV7PRGDES ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String chkavMarca_Internalname ;
      private String edtPRG_COD_Internalname ;
      private String edtPRG_DES_Internalname ;
      private String cmbPRG_EXT_Internalname ;
      private String edtPRG_WEB_Internalname ;
      private String edtPRG_SIS_Internalname ;
      private String AV8MARCA ;
      private String A127PRG_DES ;
      private String A128PRG_EXT ;
      private String A117PRG_WEB ;
      private String GXCCtl ;
      private String edtavPrgdes_Internalname ;
      private String scmdbuf ;
      private String subGrid1_Internalname ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String TempTags ;
      private String edtavPrgdes_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char5 ;
      private String tblTable2_Internalname ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String GXt_char6 ;
      private String ROClassString ;
      private String edtPRG_COD_Jsonclick ;
      private String edtPRG_DES_Jsonclick ;
      private String cmbPRG_EXT_Jsonclick ;
      private String edtPRG_WEB_Jsonclick ;
      private String edtPRG_SIS_Jsonclick ;
      private String GXt_char7 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_USUCOD ;
      private short aP1_SISCOD ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private GXCheckbox chkavMarca ;
      private GXCombobox cmbPRG_EXT ;
      private IDataStoreProvider pr_default ;
      private short[] H00542_A164PRG_SIS ;
      private String[] H00542_A117PRG_WEB ;
      private String[] H00542_A128PRG_EXT ;
      private String[] H00542_A127PRG_DES ;
      private short[] H00542_A126PRG_COD ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class hseg002__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00542 ;
          prmH00542 = new Object[] {
          new Object[] {"@AV7PRGDES",SqlDbType.Char,30,0} ,
          new Object[] {"@AV5SISCOD",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00542", "SELECT [PRG_SIS], [PRG_WEB], [PRG_EXT], [PRG_DES], [PRG_COD] FROM [SEG001] WITH (NOLOCK) WHERE ([PRG_DES] >= @AV7PRGDES) AND (@AV5SISCOD = [PRG_SIS]) ORDER BY [PRG_DES] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00542,100,1,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 30) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
       }
    }

 }

}
