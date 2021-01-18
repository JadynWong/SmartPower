const ENV = {
  dev: {
    apiUrl: 'http://localhost:44345',
    oAuthConfig: {
      issuer: 'http://localhost:44345',
      clientId: 'SmartPower_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access SmartPower',
    },
    localization: {
      defaultResourceName: 'SmartPower',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44345',
    oAuthConfig: {
      issuer: 'http://localhost:44345',
      clientId: 'SmartPower_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access SmartPower',
    },
    localization: {
      defaultResourceName: 'SmartPower',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
