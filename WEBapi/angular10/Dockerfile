#stage 1

FROM node:12.17 as node
WORKDIR /app
COPY . .
RUN npm install 
RUN npm run build --prod

#stage 2
FROM nginx:alpine
COPY --from=node /app/dist/angular10 /usr/share/nginx/html
COPY nginx.conf /etc/nginx/conf.d/default.conf
EXPOSE 1234

#stage 3
